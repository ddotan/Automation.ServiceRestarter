using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent.ObjectModel
{
    public class Result
    {
        public List<Result> InnerResults { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }
        public void AddResult(string i_Name, eOperationType i_OperationType, TimeSpan i_Elapsed, bool i_Done, string i_Exception = "")
        {
            InnerResults.Add(new Result() { Name = i_Name, OperationType = i_OperationType, Elapsed = i_Elapsed, Done = i_Done, Exception = i_Exception });
        }
        public void AddResult(Result i_Result)
        {
            InnerResults.Add(new Result() { Name = i_Result.Name, OperationType = i_Result.OperationType, Elapsed = i_Result.Elapsed, Done = i_Result.Done, Exception = i_Result.Exception });
        }

        public Result()
        {
            InnerResults = new List<Result>();
            Done = false;
        }
        public eOperationType OperationType { get; set; }
        public string Exception { get; set; }
        public TimeSpan Elapsed { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ServiceName]: " + Name);
            sb.Append(" [OperationType]: " + Enum.GetName(typeof(eOperationType), OperationType));
            string result = (Done == true) ? "Success" : "Failed";
            sb.Append(" [Result]: " + result);
            sb.Append(" [Exception]: " + Exception);


            return sb.ToString();
        }
    }
}
