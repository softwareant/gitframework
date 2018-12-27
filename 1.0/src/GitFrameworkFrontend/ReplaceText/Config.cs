using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceText
{
    class Config
    {

        public string FromText {get;set;}
        public string ToText { get; set; }
        public string Directory { get; set; }
        public string Filter { get; set; }

        public Config(string[] args)
        {
            const int PARAM_INDEX_FROMTEXT = 1;
            const int PARAM_INDEX_TOTEXT = 2;
            const int PARAM_INDEX_DIRECTORY = 3;
            const int PARAM_INDEX_FILTER = 4;
            if (args.Count() == 4 || args.Count() == 5)
            {
                this.FromText = args[PARAM_INDEX_FROMTEXT];
                this.ToText = args[PARAM_INDEX_TOTEXT];
                this.Directory = args[PARAM_INDEX_DIRECTORY];
                this.Filter = null;

                if (args.Count() == 5)
                    this.Filter = args[PARAM_INDEX_FILTER];
            }
        }
    }
}
