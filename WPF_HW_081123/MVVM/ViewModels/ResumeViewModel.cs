using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_HW_081123.MVVM.Models;

namespace WPF_HW_081123.MVVM.ViewModels
{
	public class ResumeViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private Resume _resume;
		private XmlDataService _dataService;

		public ResumeViewModel()
		{
			_resume = new Resume();
			_dataService = new XmlDataService();
		}
	}
}
