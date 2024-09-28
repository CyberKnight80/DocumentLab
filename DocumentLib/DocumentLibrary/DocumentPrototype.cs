using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentLibrary
{
    public class DocumentPrototype
    {
        public static Report Clone(Report report)
        {
            return ReportBuilder.Report().Name(report.Name).Content(report.Content).Build();
        }

        public static Memo Clone(Memo memo)
        {
            Memo m = new Memo();

            m.Name = memo.Name;
            m.Content = memo.Content;
            return m;
        }

        public static Statement Clone(Statement statement)
        {
            Statement s = new Statement();

            s.Name = statement.Name;
            s.Content = statement.Content;
            return s;
        }
    }
}
