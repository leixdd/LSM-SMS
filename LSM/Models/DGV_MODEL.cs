using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class DGV_MODEL<G> where G : INotifyPropertyChanged 
    {

        private static List<G> model_list;
        private BindingList<G> binding_model;

        public DGV_MODEL() {
            model_list = new List<G>();
            this.binding_model = new BindingList<G>(model_list);
        }

        public List<G> get_list
        {
            get { return model_list;  }
            set { model_list = value;  }
        }

        public BindingList<G> get_model {
            get { return this.binding_model; }
        }

    }
}
