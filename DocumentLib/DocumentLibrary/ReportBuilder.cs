using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentLibrary
{

    public class ReportBuilder
    {
        private static BuilderInfo _builderInfo = new BuilderInfo();

        private class BuilderInfo
        {
            public void PrintInfo()
            {
                Console.WriteLine("I am singleton");
            }
        }

        private Report _report = null;

        private ReportBuilder()
        {
            this._report = new Report();
        }

        public static ReportBuilder Report()
        {
            _builderInfo.PrintInfo();
            ReportBuilder rb = new ReportBuilder();
            return rb;
        }

        public Report Build()
        {
            return _report;
        }

        public ReportBuilder Name(string name)
        {
            this._report.Name = name;

            return this;
        }

        public ReportBuilder Description(string description)
        {
            this._report.Description = description;

            return this;
        }

        public ReportBuilder Content(string content)
        {
            this._report.Content = content;

            return this;
        }
    }
}
