using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculator
{
    class ViewModel: ObservableObject
    {
        private string _hoursTravelled;
        private string _speedTravelled;
        private ObservableCollection<Model> _dataList = new ObservableCollection<Model>();
        public string hoursTravelled
        {
            get { return _hoursTravelled; }
            set { _hoursTravelled = value; OnPropertyChanged(); }
        }
        public string speedTravelled
        {
            get { return _speedTravelled; }
            set { _speedTravelled = value; OnPropertyChanged(); }
        }
        public ObservableCollection<Model> dataList
        {
            get { return _dataList; }
            set { _dataList = value; OnPropertyChanged(); }
        }

        public void updateList()
        {
            int hours = int.Parse(_hoursTravelled);
            int speed = int.Parse(_speedTravelled);
            _dataList.Clear();
            for (int i = 1; i <= hours; i++)
            {
                Model m = new Model();
                m.hour = i;
                m.distance = i * speed;
                _dataList.Add(m);
            }
            dataList = _dataList;
        }
    }
}
