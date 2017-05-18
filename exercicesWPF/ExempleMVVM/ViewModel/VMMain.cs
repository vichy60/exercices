using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExempleMVVM.ViewModel
{
    public class VMMain : ViewModelBase
    {
        private ViewModelBase _vmCourante;
        public ViewModelBase VMCourante
        {
            get
            {
                if (_vmCourante == null)
                    _vmCourante = new VMMenu1();
                return _vmCourante;
            }
            set
            {
                SetProperty(ref _vmCourante, value);
            }
        }

        private ICommand _cmdMenu1;
        public ICommand CmdMenu1
        {
            get
            {
                if (_cmdMenu1 == null)
                    _cmdMenu1 = new RelayCommand(ActionMenu1);
                return _cmdMenu1;
            }
        }
        private void ActionMenu1(object obj)
        {
            VMCourante = new VMMenu1();
        }

        private ICommand _cmdMenu2;
        public ICommand CmdMenu2
        {
            get
            {
                if (_cmdMenu2 == null)
                    _cmdMenu2 = new RelayCommand(ActionMenu2);
                return _cmdMenu2;
            }
        }
        private void ActionMenu2(object obj)
        {
            VMCourante = new VMMenu2();
        }
    }
}
