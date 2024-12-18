using CardPlacer;

namespace CardSelector
{
    public partial class Form1 : Form
    {
        csCardSource CardsSource { get; set; }
        public Form1()
        {
            InitializeComponent();
            CardsSource = new csCardSource();
            cmbSuits.DataSource = Enum.GetValues(typeof(CardPlacer.csCardSelector.enmCardSuit));
            cmbValues.DataSource = Enum.GetValues(typeof(CardPlacer.csCardSelector.enmCardValue));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbSuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawInPicture();
        }

        private void cmbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawInPicture();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            DrawInPicture();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DrawInPicture();
        }

        void DrawInPicture()
        {
            if (cmbSuits.SelectedItem == null || cmbValues.SelectedItem == null)
                return;
            Bitmap b = CardsSource.GetCard((csCardSelector.enmCardSuit)cmbSuits.SelectedItem, (csCardSelector.enmCardValue)cmbValues.SelectedItem);
            pictureBox1.Image = b;
        }


    }
}
