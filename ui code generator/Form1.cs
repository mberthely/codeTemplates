using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_code_generator
{
    public partial class Form1 : Form
    {
        TableConfig c = new TableConfig();
        CodeProcessor p = new CodeProcessor();
        GeneratorResponse response = new GeneratorResponse();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in c.items)
            {
                treeViewProjects.Nodes.Add(item.ProjectName);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = response.responses.Find(x => x.FileName == e.Node.Text).Text; 
        }

        private void treeViewProjects_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.Nodes.Clear();
            var item = c.items.Find(x => x.ProjectName == e.Node.Text);
            response = p.Process(item);
            foreach (var item2 in response.responses)
            {
                treeView1.Nodes.Add(item2.FileName);
            }
        }
    }
}
