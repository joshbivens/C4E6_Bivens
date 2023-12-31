﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bivens_VehicleInventory
{
    public partial class VehicleInventoryForm : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public VehicleInventoryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbxType.Text == "Sedan")
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = txbLicense.Text;
                sedan.VIN = txbVIN.Text;
                vehicles.Add(sedan);
                //Refresh the list box
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfuly added sedan";
            }
            else if (cmbxType.Text == "Truck")
            {
                Truck truck = new Truck(txbVIN.Text, txbLicense.Text);
                vehicles.Add(truck);
                //Refresh the list box
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfuly added truck";
            }

        }

        private void lbInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle vehicle = (Vehicle)lbInventory.SelectedItem;
            txbSummary.Text = vehicle.GetDescription();
        }
    }
}
