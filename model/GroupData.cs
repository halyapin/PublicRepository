using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaebalTestom
{
    public class GroupData
    {
        private string name;
        private string header = "";
        private string footer = "";
        //старый конструктор GroupData принимает только 1 параметр
        public GroupData(string name)
        {
            this.name = name;

        }
        // новый конструктор с тремя апараметрами
        public GroupData(string name, string header, string footer)
        {
            this.name = name;
            this.header = header;
            this.footer = footer;

        }
        public string Name
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        }
        public string Header
        {
            set
            {
                header = value;
            }

            get
            {
                return header;
            }
        }
        public string Footer
        {
            set
            {
                footer = value;
            }

            get
            {
                return footer;
            }
        }

    }

}