#region Copyright SoftComputer Consultants 2006
// 
// This module is part of the HotelIS (Hotel Information System)
// Copyright (c) Soft Computer Consultants, Inc.  2006 
//    All Rights Reserved 
// This document contains unpublished, confidential and proprietary  
// information of Soft Computer Consultants, Inc. No disclosure or use of  
// any portion of the contents of these materials may be made without the  
// express written consent of Soft Computer Consultants, Inc. 
//  
// Author:       Dmytro Mykhalskyi
// Description:  This form is responsible for user loggin-in 
//
// Caution: -      
#endregion 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelClientPresentation;

namespace HotelClientView
{
    /// <summary> 
    /// This form is responsible for users loggin in. 
    /// </summary> 
    /// <remarks> 
    /// This class implements <see cref="ILoginWindow"/> interface. 
    /// </remarks> 
    /// <seealso cref="ILoginView"/> 
    public partial class LoginWindow : DevExpress.XtraEditors.XtraForm, ILoginView
    {
        private readonly ApplicationContext _context;
        public LoginWindow(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            btnAccept.Click += (sender, args) => Invoke(LogIn);
            btnCancel.Click += (sender, args) => Invoke(Cancel);
            selectUserName.TextChanged += (sender, args) => Invoke(LoadUsers);
        }

        public string Login
        {
            get
            {
                return selectUserName.Text;
            }
            set
            {
                selectUserName.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return inputPassword.Text;
            }
            set
            {
                inputPassword.Text = value;
            }
        }

        public string ErrorMessage
        {
            set
            {
                labelError.Text = value;
                labelError.ForeColor = System.Drawing.Color.Red;
            }
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public event Action LogIn;
        public event Action Cancel;
        public event Action LoadUsers;

        public void ShowError(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        private void Invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }


        public List<HotelClientModel.User> UsersDataSource
        {
            set 
            {
                selectUserName.Properties.Items.Clear();
                selectUserName.Properties.Items.AddRange(value);
            }
        }
    }
}