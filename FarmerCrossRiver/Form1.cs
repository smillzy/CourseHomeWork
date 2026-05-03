namespace FarmerCrossRiver
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;

        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetSelectionMode();
            ChangeData();
        }

        private void CreateList()
        {
            _leftList = new List<string>
                        {
                        "農夫","狼","羊","菜"
                        };
            _rightList = new List<string>();
        }

        private void SetSelectionMode()
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }

        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveItems(listBox1, _leftList, _rightList);
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            MoveItems(listBox2, _rightList, _leftList);
        }

        private void MoveItems(ListBox listBox, List<string> fromList, List<string> toList)
        {
            if (!SomeThingHasBeenChosen(listBox))
            {
                return;
            }

            List<string> selectedItems = listBox.SelectedItems.Cast<string>().ToList();

            if (!IsValidMove(selectedItems))
            {
                MessageBox.Show("農夫一定要同行，而且小船最多只能再帶一樣東西。");
                return;
            }

            foreach (string item in selectedItems)
            {
                fromList.Remove(item);
                toList.Add(item);
            }

            ChangeData();

            if (!IsSafe())
            {
                GameOver("你輸了！");
                return;
            }

            if (IsWin())
            {
                GameOver("恭喜，全部成功過河！");
                return;
            }
        }

        private bool SomeThingHasBeenChosen(ListBox listBox)
        {
            if (listBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("請先選擇要移動的");
                return false;
            }

            return true;
        }

        private bool IsValidMove(List<string> selectedItems)
        {
            if (!selectedItems.Contains("農夫"))
            {
                return false;
            }

            if (selectedItems.Count > 2)
            {
                return false;
            }

            return true;
        }

        private bool IsSafe()
        {
            return IsSideSafe(_leftList) && IsSideSafe(_rightList);
        }

        private bool IsSideSafe(List<string> side)
        {
            bool hasFarmer = side.Contains("農夫");
            bool hasWolf = side.Contains("狼");
            bool hasSheep = side.Contains("羊");
            bool hasVegetable = side.Contains("菜");

            if (!hasFarmer && hasWolf && hasSheep)
            {
                return false;
            }

            if (!hasFarmer && hasSheep && hasVegetable)
            {
                return false;
            }

            return true;
        }

        private void GameOver(string message)
        {
            DialogResult result = MessageBox.Show(
                message + "\n\n是否要重新開始？",
                "遊戲結束",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void RestartGame()
        {
            CreateList();
            ChangeData();

            button1.Enabled = true;
            button2.Enabled = true;
        }

        private bool IsWin()
        {
            return _rightList.Contains("農夫") &&
                   _rightList.Contains("狼") &&
                   _rightList.Contains("羊") &&
                   _rightList.Contains("菜");
        }
    }
}
