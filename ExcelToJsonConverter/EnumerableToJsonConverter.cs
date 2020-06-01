using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToJsonConverter
{
    class EnumerableToJsonConverter
    {
        public string convertToJson (IEnumerable data, int keyColumnNumber, int ValueColumnNumber)
        {
            string jsonString = "{";

            Queue<JsonElement> dataQ = convertToQueue(data, keyColumnNumber, ValueColumnNumber);

            JsonElement preData;
            JsonElement CurrentData = new JsonElement();

            while (dataQ.Count > 0)
            {
                preData = CurrentData;
                CurrentData = dataQ.Dequeue();

                string strCloseBraces = AddCloseBraces(CurrentData.parents, preData.parents);
                if (!String.IsNullOrEmpty(strCloseBraces))
                    jsonString = jsonString.Remove(jsonString.Length - 1) + strCloseBraces;

                jsonString += AddOpenBraces(CurrentData.parents, preData.parents);

                jsonString += AddValue(CurrentData);
            }

            jsonString = jsonString.Remove(jsonString.Length - 1) + AddCloseBracesToTheEnd(CurrentData.parents.Count());

            return jsonString;
        }


        private string AddCloseBracesToTheEnd(int count)
        {
            string retValue = "";
            string newLine;
            while (count >= 0)
            {
                newLine = "";
                for (int j = 0; j < count; j++)
                {
                    newLine += "  ";
                }
                newLine += "}";
                retValue += Environment.NewLine + newLine;
                count--;
            }
            return retValue;
        }

        private string AddOpenBraces(string[] currentDataParents, string[] preDataParent)
        {
            string retValue = "";
            string newLine = "";
            for (int i = 0; i < currentDataParents.Count(); i++)
            {
                if (preDataParent == null || preDataParent.Count() < i + 1 || preDataParent[i] != currentDataParents[i])
                {
                    for (int j = 0; j <= i; j++)
                    {
                        newLine += "  ";
                    }
                    newLine += "\"" + currentDataParents[i] + "\": {";
                    retValue += Environment.NewLine + newLine;
                    newLine = "";
                }
            }
            return retValue;
        }

        private string AddCloseBraces(string[] currentDataParents, string[] preDataParent)
        {
            string retValue = ",";
            string newLine = "";
            if (preDataParent != null)
            {
                for (int i = preDataParent.Count() - 1; i >= 0; i--)
                {
                    if (currentDataParents.Count() < i + 1 ||
                          (currentDataParents.Count() >= i + 1 && preDataParent[i] != currentDataParents[i]))
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            newLine += "  ";
                        }
                        retValue = retValue.Remove(retValue.Length - 1);
                        newLine += "},";
                        retValue += Environment.NewLine + newLine;
                        newLine = "";
                    }
                }
            }
            return retValue == "," ? "" : retValue;
        }

        private string AddValue(JsonElement data)
        {
            string retValue = Environment.NewLine;
            for (int j = 0; j <= data.parents.Count(); j++)
            {
                retValue += "  ";
            }
            string value = (data.value != null) ? data.value : "***NO VALUE***";
            retValue += "\"" + data.key + "\": \"" + value + "\",";

            return retValue;
        }

        private Queue<JsonElement> convertToQueue(IEnumerable data, int keyColumnNumber, int dataColumnNumber)
        {
            Queue<JsonElement> retValue = new Queue<JsonElement>();
            foreach (DataRow dr in data)
            {
                var keys = dr[keyColumnNumber].ToString().Split('/');
                var value = dr.ItemArray[dataColumnNumber].ToString().Trim();
                JsonElement jsonElement = new JsonElement()
                {
                    key = keys[keys.Count() - 1],
                    parents = keys.Take(keys.Count() - 1).ToArray(),
                    value = !String.IsNullOrEmpty(value) ? value : "***NO VALUE***"
                };
                retValue.Enqueue(jsonElement);
            }
            return retValue;
        }

    }
}
