using System.Windows.Forms;

namespace PCA_with_number_files {
    public partial class Window : Form {
        string RawOuput;
        string CoVarOut;
        string EigenOut;
        public Window() {
            InitializeComponent();

        }

        private void BttnOpen_Click(object sender, System.EventArgs e) {
            FileDiag.ShowDialog();
        }

        private void FileDiag_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            DataStructure.clear();
            DataReader.FilePath = FileDiag.FileName;
            LblFilePath.Text = FileDiag.FileName;
            DataStructure.Data = DataReader.Data; //assign the data created from the reader to the data storage
            DataStructure.Process(); //Process
            RawOuput = DataStructure.toString();
            CoVarOut = DataStructure.CoVarToString();
            EigenOut = DataStructure.eigenToString();
            TxtBoxDataDisplay.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace, TxtBoxDataDisplay.Font.Size);
            TxtBoxDataDisplay.Text = RawOuput;
            RadButRawView.Checked = true;
        }

        private void CheckedChanged(object sender, System.EventArgs e) {
            if (RadButRawView.Checked) {
                //Show 
                TxtBoxDataDisplay.Text = RawOuput;
                //Hide all others
            }
            else if (RadButCoVar.Checked) {
                //Show 
                TxtBoxDataDisplay.Text = CoVarOut;
                //Hide all others
            }
            else if (RadButEigen.Checked) {
                TxtBoxDataDisplay.Text = EigenOut;
            }
            else if (RadButUser.Checked) {
                TxtBoxDataDisplay.Text = UserInput.toString();
            }
        }

        private void FileDialogUserInput_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            DataReader.FilePath = FileDialogUserInput.FileName;
            UserInput.Data = DataReader.Data;
            UserInput.Process();
        }

        private void BttnUserOpen_Click(object sender, System.EventArgs e) {
            FileDialogUserInput.ShowDialog();
        }
    }
}
