using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;

namespace Lab31
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryExpression qe = new QueryExpression("contact");
            ColumnSet cs = new ColumnSet();
            FilterExpression fe = new FilterExpression();
            //ConditionExpression ce = new ConditionExpression();
            cs.AddColumns("fullname", "parentcustomerid");
            //ce.AttributeName = "jobtitle";
            //ce.Operator = ConditionOperator.Equal;
            //ce.Values.Add("Менеджер по закупкам");
            //fe.AddCondition(ce);
            qe.ColumnSet = cs;
            qe.Criteria.AddFilter(fe);
            EntityCollection contacts = Service.Service.GetOrganization().RetrieveMultiple(qe);
            foreach (var item in contacts.Entities)
            {
                Console.WriteLine(item.Attributes["fullname"].ToString());
            }
            Console.Read();
        }
    }
}
