using System.Collections.ObjectModel;
using System.Linq;

namespace WpfTreeView
{
    class DirectoryStructureViewModel : BaseViewModel
    {
        #region Public Properites
        public ObservableCollection<DirectoryItemViewModel> Items { get; set; }
        #endregion

        #region Constructor
        public DirectoryStructureViewModel()
        {
            var childern = DirectoryStructure.GetLigicalDrives();
            this.Items = new ObservableCollection<DirectoryItemViewModel>(childern.Select(drive => new DirectoryItemViewModel(drive.FullPath, DirectoryItemType.Drive)));
        }

        #endregion
    }
}
