using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPet
{
    public partial class PetCreator : Form
    {
        public PetCreator()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            String newName = name.Text;
            

            Pet newPet = new Pet();
            newPet.setName(newName);

            //Tried to call YourPet form but threw an exception. Exception: 
            // System.InvalidOperationException: 'Starting a second message loop on a single thread is not a valid operation. Use Form.ShowDialog instead.'
            // Application.Run(new YourPet());
            
        }
    }
}
