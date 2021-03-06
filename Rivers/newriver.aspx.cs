﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;
using System.Configuration;


namespace SMWaterLevel.Rivers
{
    public partial class newriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Rivers/riverlist.aspx");
        }
        public bool IsValidData()
        {
            string error = "";
            bool validData = true;
            if (txtRiverName.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("RiverResource", "requireRivername").ToString();
                validData = false;
            }

            if (!validData)
            {
                ShowErrorMessage(error);
            }
            return validData;
        }
        public void ShowErrorMessage(string error)
        {
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageOpenTag").ToString();
            ltlMessage.Text += error;
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageCloseTag").ToString();
        }
        protected string GetMarkers()
        {
            string markers = "var marker = new google.maps.Marker({position: new google.maps.LatLng(28.3213,77.5435), map: myMap,title: 'Software Myanmar'});";

            return markers;

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            River River = new River();
            RiverTableAdapter RiverTableAdapter = new RiverTableAdapter();

            if (IsValidData())
            {
                River.RiverName = txtRiverName.Text.Trim();
                River.RiverID = Guid.NewGuid().ToString();
                River.Latitude = txtLatitude.Text.Trim();
                River.Longitude = txtLongitude.Text.Trim();
                River.Description = txtDescription.Text.Trim();
                River.Status = "ACTIVE";

                if (RiverTableAdapter.Insert(River) > 0)
                {
                    ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Created <b>" + txtRiverName.Text.Trim() + "</b>.</div>";
                    Response.Redirect("~/Rivers/riverlist.aspx");

                }
            }
        }

        protected void btnViewMap_Click(object sender, EventArgs e)
        {
            ltlViewMap.Text = "<iframe width=\"100%\" height=\"500\" src=\"https://maps.google.com/maps?width=100%&amp;height=500&amp;hl=en&amp;coord="+ txtLatitude.Text + "," + txtLongitude.Text + "&amp;q=" + txtRiverName.Text + "+(" + txtDescription.Text + ")&amp;ie=UTF8&amp;t=&amp;z=14&amp;iwloc=B&amp;output=embed\" frameborder=\"0\" scrolling=\"no\" marginheight=\"0\" marginwidth=\"0\"></iframe>";
        }
    }
}