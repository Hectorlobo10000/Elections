using Caliburn.Micro;

namespace Elections.Server.Handler.ViewModels
{
    public class ControlPanelViewModel : PropertyChangedBase
    {

        StudentViewModel _studentView;
        public StudentViewModel StudentView
        {
            get { return _studentView; }
            set
            {
                _studentView = value;
                NotifyOfPropertyChange(() => StudentView);
            }
        }

        RecordViewModel _recordView;
        public RecordViewModel RecordView
        {
            get
            { return _recordView; }
            set
            {
                _recordView = value;
                NotifyOfPropertyChange(() => RecordView);
            }
        }

        ListStudentsViewModel _listStudentsView;
        public ListStudentsViewModel ListStudentsView
        {
            get { return _listStudentsView; }
            set
            {
                _listStudentsView = value;
                NotifyOfPropertyChange(() => ListStudentsView);
            }
        }

        public ControlPanelViewModel()
        {
            ListStudentsView = new ListStudentsViewModel();
            RecordView = new RecordViewModel();
            StudentView = new StudentViewModel();
        }
         
    }
}