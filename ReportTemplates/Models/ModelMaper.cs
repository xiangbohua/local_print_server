using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReportTemplates.Models
{
    public class ModelMaper
    {
        private static Queue<PrintModel> _printJobs = new Queue<PrintModel>();
        private static object jobLock = new object();

        public static void AddJob(PrintModel m)
        {
            lock(jobLock)
            {
                _printJobs.Enqueue(m);
            }
        }

        public static PrintModel PopAJob()
        {
            lock (jobLock)
            {
                if (_printJobs.Count > 0) 
                    return _printJobs.Dequeue();
                return null;
            }
        }

        public static PrintModel GetPrintModel(string modelData)
        {
            JObject jo = (JObject)JsonConvert.DeserializeObject(modelData);
            string print_type = jo["print_type"].ToString();

            Type modelType = GetPrintModelType(print_type);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            PrintModel model = (PrintModel)serializer.Deserialize(modelData, modelType);

            return model;
        }

        private static Type GetPrintModelType(string typeName)
        {
            Type type = Type.GetType("ReportTemplates.Models."+ typeName);
            if (type == null)
            {
                throw new ArgumentException("传入的打印类型未找到");
            }
            return type;
        }
    }
}
