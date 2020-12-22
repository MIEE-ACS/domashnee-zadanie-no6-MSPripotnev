using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework6
{
    public partial class Form1 : Form
    {
        List<Body> bodies;
        List<Body> Bodies
        {
            get
            {
                return bodies;
            }
            set
            {
                bodies = value;
                BodiesLV.Items.Clear();
                foreach (Body el in bodies)
                    BodiesLV.Items.Add(el.ToString(), 
                        el is Cube ? 0 : el is Sphere ? 1 : el is Cone ? 2
                        : throw new Exception("Неизвестный тип данных!"));
                if (BodiesLV.Items.Count != 0)
                    BodiesLV.RedrawItems(0, BodiesLV.Items.Count - 1, true);
                
            }
        }
        public Form1()
        {
            InitializeComponent();
            Bodies = new List<Body>();
            BasicFounders();
        }

        private void BasicFounders()
        {
            Cube[] cubes =
            {
                new Cube(1),
                new Cube(2),
                new Cube(3)
            };

            Sphere[] spheres =
            {
                new Sphere(1),
                new Sphere(2),
                new Sphere(3)
            };

            Cone[] cones =
            {
                new Cone(1, 1),
                new Cone(2, 2),
                new Cone(3, 3)
            };

            Bodies.AddRange(cubes);
            Bodies.AddRange(spheres);
            Bodies.AddRange(cones);
            Bodies = Bodies;
        }

        private void addFigureButton_Click(object sender, EventArgs e)
        {
            try
            {
                Body b;
                switch (typeCB.Text)
                {
                    case nameof(Cube):
                        b = new Cube(radiusNUD.Value);
                       break;
                    case nameof(Sphere):
                        b = new Sphere(radiusNUD.Value);
                            break;
                    case nameof(Cone):
                        b = new Cone(hNUD.Value, radiusNUD.Value);
                        break;
                    default: b = null; throw new Exception("Неверный тип фигуры!");
                }
                Bodies.Add(b);
                Bodies = Bodies;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (BodiesLV.SelectedItems.Count == 0) return;
            var b = Bodies[BodiesLV.SelectedIndices[0]];
            Bodies.RemoveAll(p => p.Equals(b));
            Bodies = Bodies;
            
            hNUD.Value = radiusNUD.Value = default;
            hInfoLabel.Visible = hNUD.Visible =
                RInfoLabel.Visible = radiusNUD.Visible = default;
            AreaTB.Text = VolumeTB.Text = default;
        }

        private void typeCB_SelectedIndexChanged(object sender, EventArgs e) =>
            RInfoLabel.Visible = radiusNUD.Visible =
                    (hInfoLabel.Visible = hNUD.Visible = (typeCB.Text == nameof(Cone))) 
            || typeCB.SelectedIndex != -1;

        private void EmployersLV_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var lv = sender as ListView;
            bool itnull = lv.SelectedItems.Count == 0;
            typeCB.SelectedIndex = (typeCB.Enabled = itnull) ? -1 : lv.SelectedItems[0].ImageIndex;
            if (!itnull)
            {
                var b = Bodies[lv.SelectedIndices[0]];
                radiusNUD.Value = ((b as Cube)?.R ?? (b as Sphere)?.R ?? (b as Cone)?.R).Value;
                radiusNUD.Visible = RInfoLabel.Visible = true;
                _ = (hInfoLabel.Visible = hNUD.Visible = b is Cone) ? hNUD.Value = (b as Cone).H : 0;
            }
            else
            {
                hNUD.Value = radiusNUD.Value = default;
                hInfoLabel.Visible = hNUD.Visible = 
                    RInfoLabel.Visible = radiusNUD.Visible = default;
                AreaTB.Text = VolumeTB.Text = default;
            }
        }

        private void NUD_ValueChanged(object sender, EventArgs e)
        {
            var senderc = sender as NumericUpDown;
            if (BodiesLV.SelectedIndices.Count != 0 && senderc.Value != default)
            {
                int i = BodiesLV.SelectedIndices[0];
                _ = Bodies[i] is Cube c ? c.R = senderc.Value : Bodies[i] is Sphere s ? s.R = senderc.Value 
                    : Bodies[i] is Cone cn ? senderc.Name.Contains("radius") ? cn.R = senderc.Value : cn.H = senderc.Value
                    : throw new Exception("X3");
                BodiesLV.SelectedItems[0].Text = Bodies[i].ToString();
                AreaTB.Text = $"{Bodies[i].Area():0.0000}";
                VolumeTB.Text = $"{Bodies[i].Volume():0.0000}";
            }
        }
    }
}
