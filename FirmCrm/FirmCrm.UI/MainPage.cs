using System;
using System.Drawing;
using System.Windows.Forms;
using FirmCrm.UI.Forms;

namespace FirmCrm.UI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            trvMenu.ExpandAll();
            //forms not default on toplevel
            addCatView.TopLevel = false;
            addCustView.TopLevel = false;
            addOrdView.TopLevel = false;
            addProdView.TopLevel = false;
            addSupView.TopLevel = false;
            dashView.TopLevel = false;
            stockView.TopLevel = false;
            searchCatView.TopLevel = false;
            seachCustView.TopLevel = false;
            searchOrderView.TopLevel = false;
            searchProductView.TopLevel = false;
            searchSupView.TopLevel = false;
        }

        //load forms
        AddCategory addCatView = new AddCategory();
        AddCustomer addCustView = new AddCustomer();
        AddOrder addOrdView = new AddOrder();
        AddProduct addProdView = new AddProduct();
        AddSupplier addSupView = new AddSupplier();
        Dashboard dashView = new Dashboard();
        Stock stockView = new Stock();
        SearchCategory searchCatView = new SearchCategory();
        SearchCustomer seachCustView = new SearchCustomer();
        SearchOrder searchOrderView = new SearchOrder();
        SearchProduct searchProductView = new SearchProduct();
        SearchSupplier searchSupView = new SearchSupplier();
        
        private void trvMenu_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            //add forms to pnlView
            pnlView.Controls.AddRange(new Control[]
            {
                addCatView, addCustView, addOrdView, addProdView, addSupView, dashView, stockView, searchCatView, seachCustView, searchOrderView, searchProductView, searchSupView
            });
            //switch menu's
            switch (trvMenu.SelectedNode.Text)
            {
                case "Add Product":
                    addProdView.Show();
                    addProdView.BringToFront();
                    break;
                case "Add Supplier":
                    addSupView.Show();
                    addSupView.BringToFront();
                    break;
                case "Add Category":
                    addCatView.Show();
                    addCatView.BringToFront();
                    break;
                case "Add Customer":
                    addCustView.Show();
                    addCustView.BringToFront();
                    break;
                case "Add Order":
                    addOrdView.Show();
                    addOrdView.BringToFront();
                    break;
                case "DASHBOARD":
                    dashView.Show();
                    dashView.BringToFront();
                    break;
                case "STOCK":
                    stockView.Show();
                    stockView.BringToFront();
                    break;
                case "Search Product":
                    searchProductView.Show();
                    searchProductView.BringToFront();
                    break;
                case "Search Supplier":
                    searchSupView.Show();
                    searchSupView.BringToFront();
                    break;
                case "Search Category":
                    searchCatView.Show();
                    searchCatView.BringToFront();
                    break;
                case "Search Customer":
                    seachCustView.Show();
                    seachCustView.BringToFront();
                    break;
                case "Search Order":
                    searchOrderView.Show();
                    searchOrderView.BringToFront();
                    break;
                case "PRODUCT":
                    addProdView.Show();
                    addProdView.BringToFront();
                    break;
                case "CUSTOMER":
                    addCustView.Show();
                    addCustView.BringToFront();
                    break;
                case "CATEGORY":
                    addCatView.Show();
                    addCatView.BringToFront();
                    break;
                case "SUPPLIER":
                    addSupView.Show();
                    addSupView.BringToFront();
                    break;
                case "ORDER":
                    addOrdView.Show();
                    addOrdView.BringToFront();
                    break;
            }
        }

        //Set ticktimer for datetime in header
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }
    }
}
