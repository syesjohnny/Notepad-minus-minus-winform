using Dark.Net;
using NotePadMinusMinus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class MainFormContainer : Form
{
    public List<MainForm> Forms { get; set; } = new();
    public MainFormContainer()
    {
        MainForm form = new(this);
        DarkNet.Instance.SetWindowThemeForms(form, Theme.Auto);
        form.Show();
        Forms.Add(form);
    }
    public void AddNewForm(MainForm form)
    {
        Forms.Add(form);
    }
    public void OnCloseFormChecking(MainForm form)
    {
        Forms.Remove(form);
        if (Forms.Count == 0) Application.Exit();
    }

    private void InitializeComponent()
    {

    }

    protected override void SetVisibleCore(bool value)
    {
        if (!this.IsHandleCreated)
        {
            this.CreateHandle();
            value = false;   // Prevent window from becoming visible
        }
        base.SetVisibleCore(value);
    }
}
