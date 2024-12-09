using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

using MoggInspectorLib;

namespace MoggInspector
{
    public partial class MoggInspector : Form
    {
        public MoggInspector()
        {
            InitializeComponent();
            this.DragEnter += new DragEventHandler(MoggInspector_DragEnter);
            this.DragDrop += new DragEventHandler(MoggInspector_DragDrop);
        }

        void MoggInspector_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void MoggInspector_DragDrop(object sender, DragEventArgs e)
        {
            uint OggOffset;
            byte[] MoggHeader;
            var dropped = (string[])e.Data.GetData(DataFormats.FileDrop);
            var files = dropped.ToList();

            if (files.Count() == 0)
                throw new Exception(string.Format("no files dropped!"));
            if (files.Count() > 1)
                throw new Exception(string.Format("more than one file dropped, one only!"));

            string fileName = files[0];

            using (var stream = File.Open(fileName, FileMode.Open))
            {
                using (var reader = new BinaryReader(stream))
                {
                    stream.Seek(4, SeekOrigin.Begin);
                    OggOffset = reader.ReadUInt32();
                    stream.Seek(0, SeekOrigin.Begin);
                    MoggHeader = reader.ReadBytes((int)(OggOffset));
                }
            }
            var kc = new KeyChain();
            kc.DeriveKeys(MoggHeader, true);

        }
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void XboxIndexBox_TextChanged(object sender, EventArgs e)
        {
            HideCaret(XboxIndexBox.Handle);
        }

        private void MoggInspector_Load(object sender, EventArgs e)
        {
            XboxIndexBox.Text = "";
            Ps3IndexBox.Text = "";
            magicBBox.Text = "";
            magicABox.Text = "";
            CorrectedPS3MaskBox.Text = "";
            EncTypeDescBox.Text = "";
            PS3MaskBox.Text = "";
            XboxMaskBox.Text = "";
            EncSubVerBox.Text = "";
            NonceBox.Text = "";
            AESKeyBox.Text = "";
            EncVerBox.Text = "";
            MaskErrorLbl.Visible = false;
            PatchMaskBtn.Visible = false;
            CorrectedPS3MaskBox.Visible = false;

        }
    }
}
