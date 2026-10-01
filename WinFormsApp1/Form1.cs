using System.Globalization;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    private readonly List<(string Name, decimal Price)> menuItems =
    [
        ("Tort", 4.50m),
        ("Kola", 2.00m),
        ("Soyuq çay", 2.50m),
        ("Hamburger", 6.00m),
        ("Sendviç", 5.00m),
        ("Pizza", 7.50m),
        ("Keks", 3.00m),
        ("Hot-doq", 4.00m),
        ("Peçenye", 3.50m)
    ];

    private readonly ListBox basketList = new();
    private readonly TextBox amountTextBox = new();
    private readonly TextBox balanceTextBox = new();
    private readonly TextBox totalTextBox = new();
    private readonly FlowLayoutPanel menuPanel = new();
    private decimal total;

    public Form1()
    {
        InitializeComponent();
        BuildUserInterface();
    }

    private void BuildUserInterface()
    {
        Text = "Cafe system";
        ClientSize = new Size(900, 560);
        MinimumSize = new Size(760, 500);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.WhiteSmoke;

        var leftPanel = new Panel { Dock = DockStyle.Left, Width = 180, BackColor = Color.LightGray, Padding = new Padding(20) };
        var cafeLabel = new Label
        {
            Text = "Cafe",
            Dock = DockStyle.Top,
            Height = 55,
            Font = new Font("Arial", 18, FontStyle.Bold | FontStyle.Italic),
            TextAlign = ContentAlignment.MiddleCenter
        };
        var menuGroup = new GroupBox { Text = "MENU", Dock = DockStyle.Fill, Padding = new Padding(12) };
        menuPanel.Dock = DockStyle.Fill;
        menuPanel.AutoScroll = true;
        menuPanel.Padding = new Padding(8);
        menuPanel.WrapContents = true;
        menuPanel.FlowDirection = FlowDirection.LeftToRight;

        foreach (var item in menuItems)
        {
            var button = new Button
            {
                Text = $"{item.Name}\n{item.Price:0.00} ₼",
                Tag = item,
                Width = 125,
                Height = 75,
                Margin = new Padding(8),
                BackColor = Color.White
            };
            button.Click += AddToBasket;
            menuPanel.Controls.Add(button);
        }

        menuGroup.Controls.Add(menuPanel);

        var paymentGroup = new GroupBox { Text = "Ödəniş", Dock = DockStyle.Bottom, Height = 170, Padding = new Padding(10) };
        var paymentLayout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 3 };
        paymentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
        paymentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
        AddPaymentRow(paymentLayout, 0, "Məbləğ:", amountTextBox);
        AddPaymentRow(paymentLayout, 1, "Qalıq:", balanceTextBox);
        var calculateButton = new Button { Text = "Hesabla", Dock = DockStyle.Fill, BackColor = Color.LightGreen };
        calculateButton.Click += CalculateBalance;
        paymentLayout.Controls.Add(calculateButton, 0, 2);
        var clearButton = new Button { Text = "Təmizlə", Dock = DockStyle.Fill, BackColor = Color.LightCoral };
        clearButton.Click += ClearPaymentFields;
        paymentLayout.Controls.Add(clearButton, 1, 2);
        paymentGroup.Controls.Add(paymentLayout);
        leftPanel.Controls.Add(cafeLabel);
        leftPanel.Controls.Add(menuGroup);
        leftPanel.Controls.Add(paymentGroup);

        var rightPanel = new Panel { Dock = DockStyle.Right, Width = 250, Padding = new Padding(12) };
        var basketLabel = new Label { Text = "Səbət", Dock = DockStyle.Top, Height = 30, Font = new Font(Font, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter };
        basketList.Dock = DockStyle.Fill;
        basketList.IntegralHeight = false;
        var basketButtons = new TableLayoutPanel { Dock = DockStyle.Bottom, Height = 115, RowCount = 3, ColumnCount = 1 };
        var removeButton = new Button { Text = "Səbətdən sil", Dock = DockStyle.Fill };
        removeButton.Click += RemoveFromBasket;
        var refreshButton = new Button { Text = "Yenilə", Dock = DockStyle.Fill };
        refreshButton.Click += RefreshOrder;
        var checkoutButton = new Button { Text = "Yekun hesab", Dock = DockStyle.Fill };
        checkoutButton.Click += ShowTotal;
        basketButtons.Controls.Add(removeButton, 0, 0);
        basketButtons.Controls.Add(refreshButton, 0, 1);
        basketButtons.Controls.Add(checkoutButton, 0, 2);
        var totalPanel = new TableLayoutPanel { Dock = DockStyle.Bottom, Height = 35, ColumnCount = 2 };
        totalPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
        totalPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
        totalPanel.Controls.Add(new Label { Text = "Hesab:", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
        totalTextBox.ReadOnly = true;
        totalTextBox.Dock = DockStyle.Fill;
        totalPanel.Controls.Add(totalTextBox, 1, 0);
        rightPanel.Controls.Add(basketList);
        rightPanel.Controls.Add(totalPanel);
        rightPanel.Controls.Add(basketButtons);
        rightPanel.Controls.Add(basketLabel);

        Controls.Add(menuGroup);
        Controls.Add(leftPanel);
        Controls.Add(rightPanel);
    }

    private static void AddPaymentRow(TableLayoutPanel layout, int row, string label, TextBox textBox)
    {
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33f));
        layout.Controls.Add(new Label { Text = label, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, row);
        textBox.Dock = DockStyle.Fill;
        layout.Controls.Add(textBox, 1, row);
    }

    private void AddToBasket(object? sender, EventArgs e)
    {
        if (sender is Button { Tag: ValueTuple<string, decimal> item })
        {
            basketList.Items.Add($"{item.Item1} - {item.Item2:0.00} ₼");
            total += item.Item2;
        }
    }

    private void RemoveFromBasket(object? sender, EventArgs e)
    {
        if (basketList.SelectedItem is not string selectedItem)
        {
            return;
        }

        var foodName = selectedItem.Split(" - ", StringSplitOptions.None)[0];
        var menuItem = menuItems.First(item => item.Name == foodName);
        basketList.Items.RemoveAt(basketList.SelectedIndex);
        total -= menuItem.Price;
        MessageBox.Show($"{foodName} səbətdən silindi", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void RefreshOrder(object? sender, EventArgs e)
    {
        var result = MessageBox.Show("Xanalar sıfırlansınmı?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result != DialogResult.Yes)
        {
            return;
        }

        basketList.Items.Clear();
        total = 0;
        totalTextBox.Clear();
        amountTextBox.Clear();
        balanceTextBox.Clear();
    }

    private void ShowTotal(object? sender, EventArgs e)
    {
        if (basketList.Items.Count == 0)
        {
            MessageBox.Show("Səbətdə yemək yoxdur!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        totalTextBox.Text = total.ToString("0.00", CultureInfo.CurrentCulture);
    }

    private void CalculateBalance(object? sender, EventArgs e)
    {
        if (basketList.Items.Count == 0)
        {
            MessageBox.Show("Səbətdə yemək yoxdur!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!TryParseAmount(amountTextBox.Text, out var amount))
        {
            MessageBox.Show("Daxil edilən məbləğ düzgün deyil.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (amount < total)
        {
            balanceTextBox.Clear();
            MessageBox.Show("Daxil edilən məbləğ hesabdan azdır", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        totalTextBox.Text = total.ToString("0.00", CultureInfo.CurrentCulture);
        balanceTextBox.Text = (amount - total).ToString("0.00", CultureInfo.CurrentCulture);
    }

    private void ClearPaymentFields(object? sender, EventArgs e)
    {
        amountTextBox.Clear();
        balanceTextBox.Clear();
    }

    private static bool TryParseAmount(string text, out decimal amount)
    {
        return decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out amount)
            || decimal.TryParse(text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out amount);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
