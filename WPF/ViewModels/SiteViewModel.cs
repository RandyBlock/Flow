using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Flow.WPF.Helpers;
using Flow.WPF.Models;
using Flow.WPF.Services;

namespace Flow.WPF.ViewModels
{
    public class SiteViewModel:ObservableObject
    {
        private FlowDBContextFactory _contextfactory=new FlowDBContextFactory();
        private FlowDBContext? _context; 
       
      // GenericDataServices<FlowDBContextFactory> _contextfactory;
        private int? _siteId;
        private int _selectedSite;
        private Site? _currentSite;

        //private ICommand GetProductCommand;
       // private ICommand SaveProductCommand;
        public int selectedSite
        {
            get { return _selectedSite; }
            set { _selectedSite = value; }
        }
      public Site? CurrentSite
        {
            get { return _currentSite; }
            set
            {
                if (value != _currentSite)
                { 
                    _currentSite = value;
                    OnPropertyChanged("CurrentSite");
                }
            }
        }   

    }
}