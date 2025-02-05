namespace Calculator;

public partial class CalculatorApp : Form
{
    private SynchronizationContext main;

    public CalculatorApp()
    {
        InitializeComponent();
        main = SynchronizationContext.Current;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        int a = int.Parse(txtA.Text);
        int b = int.Parse(txtB.Text);
        //SynchronizationContext sub = SynchronizationContext.Current;
        //int result = LongAdd(a, b);
        //UpdateAnswer(result);
        //var tx = Task.Run(() => LongAdd(a, b));
        //tx.ContinueWith(prevTask =>
        //    {
        //        main.Post(UpdateAnswer, prevTask.Result);
        //    });
        //tx.ContinueWith
        //int result=await LongAddAsync(a, b);
        int result = DoSomething(a, b).Result;
        UpdateAnswer(result);
    }

    private async Task<int> DoSomething(int a, int b)
    {
        int res = await LongAddAsync(a, b);
        return res;
    }

    private void UpdateAnswer(object result)
    {
        lblAnswer.Text = result.ToString();
    }

    private int LongAdd(int a, int b)
    {
        Task.Delay(10000).Wait();
        return a + b;
    }

    private void CalculatorApp_Click(object sender, EventArgs e)
    {
        //Task.Run(() => button1_Click(this, EventArgs.Empty));
    }
    private Task<int> LongAddAsync(int a, int b)
    {
        return Task.Run(() => LongAdd(a, b));
    }
}