using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Button = System.Windows.Controls.Button;
using Label = System.Windows.Controls.Label;
using MessageBox = System.Windows.Forms.MessageBox;
using TextBox = System.Windows.Controls.TextBox;

namespace AddressBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Phonebook pb;
        string filename = ""; //to save the file path of the image to save to each contact
        public MainWindow()
        {
            InitializeComponent();

            //to show login screen if already registered and if not then show register screen
            if (Properties.Settings.Default.Username != "" && Properties.Settings.Default.Password != "")
            {
                registerGrid.Visibility = Visibility.Hidden;
                loginGrid.Visibility = Visibility.Visible;
                addressbookGrid.Visibility = Visibility.Hidden;
                profileGrid.Visibility = Visibility.Hidden;
            }
            else
            {
                registerGrid.Visibility = Visibility.Visible;
                loginGrid.Visibility = Visibility.Hidden;
                addressbookGrid.Visibility = Visibility.Hidden;
                profileGrid.Visibility = Visibility.Hidden;
            }

            pb = new Phonebook();
            //setting the contacts list of phonebook class as itemsource of listbox
            this.listItems.ItemsSource = pb.getAll();

            pb.addContact(new Contact()
            {
                firstName = "Hamza",
                lastName = "Ali",
                countryCode = "+92",
                phoneNo = "3005499999",
                photoAddress = "D:\\Study\\6th Semester\\Visual Programming\\user.png",
                Company = "Comsats",
                jobTitle = "Student",
                Email = "hmemail@gmail.com",
                Address = "Islamabad"

            });
            pb.addContact(new Contact()
            {
                firstName = "Umer",
                lastName = "Khalid",
                countryCode = "+92",
                phoneNo = "312555834",
                photoAddress = "D:\\Study\\6th Semester\\Visual Programming\\user.png",
                Company = "Awan Sons",
                jobTitle = "Bussinessman",
                Email = "umarkhalid@gmail.com",
                Address = "Bahawalpur"

            });
            pb.addContact(new Contact()
            {
                firstName = "Haider",
                lastName = "Ali",
                countryCode = "+92",
                phoneNo = "3431857835",
                photoAddress = "D:\\Study\\6th Semester\\Visual Programming\\user.png",
                Company = "Comsats",
                jobTitle = "Student",
                Email = "haider_7@gmail.com",
                Address = "Islamabad"

            });
            pb.addContact(new Contact()
            {
                firstName = "Zain",
                lastName = "Ali",
                countryCode = "+92",
                phoneNo = "3004531204",
                photoAddress = "D:\\Study\\6th Semester\\Visual Programming\\user.png",
                Company = "NUST",
                jobTitle = "Student",
                Email = "zainali19@gmail.com",
                Address = "Islamabad"

            });
            pb.addContact(new Contact()
            {
                firstName = "Hamza",
                lastName = "Ahmed",
                countryCode = "+92",
                phoneNo = "3006852165",
                photoAddress = "D:\\Study\\6th Semester\\Visual Programming\\user.png",
                Company = "NUST",
                jobTitle = "Student",
                Email = "hamza17@yahoo.com",
                Address = "Islamabad"

            });
            pb.addContact(new Contact()
            {
                firstName = "Hashim",
                lastName = "Raza",
                countryCode = "+92",
                phoneNo = "3006431256",
                photoAddress = "D:\\Study\\6th Semester\\Visual Programming\\user.png",
                Company = "Comsats",
                jobTitle = "Student",
                Email = "hashim12@gmail.com",
                Address = "Islamabad"

            });



        }


        //to remove the placeholder texts when focused
        private void TextFields_GotFocus(object sender, RoutedEventArgs e)
        {

            if (((TextBox)sender).Name.ToString() == "nameBox")
            {
                if (((TextBox)sender).Text.ToString() == "Full name")
                {
                    this.nameBox.Text = "";
                }
            }
            else if (((TextBox)sender).Name.ToString() == "codeBox")
            {
                if (((TextBox)sender).Text.ToString() == "Code")
                {
                    this.codeBox.Text = "";
                }
            }
            else if (((TextBox)sender).Name.ToString() == "searchBox")
            {
                if (((TextBox)sender).Text.ToString() == "Search")
                {
                    this.searchBox.Text = "";
                }
            }
            else if (((TextBox)sender).Name.ToString() == "numberBox")
            {
                if (((TextBox)sender).Text.ToString() == "Number")
                {
                    this.numberBox.Text = "";
                }
            }
            else if (((TextBox)sender).Name.ToString() == "companyBox")
            {
                if (((TextBox)sender).Text.ToString() == "Company")
                {
                    this.companyBox.Text = "";
                }
            }
            else if (((TextBox)sender).Name.ToString() == "jobtitleBox")
            {
                if (((TextBox)sender).Text.ToString() == "Job Title")
                {
                    this.jobtitleBox.Text = "";
                }
            }
            else if (((TextBox)sender).Name.ToString() == "emailBox")
            {
                if (((TextBox)sender).Text.ToString() == "Email")
                {
                    this.emailBox.Text = "";
                }
            }
            else if (((TextBox)sender).Name.ToString() == "addressBox")
            {
                if (((TextBox)sender).Text.ToString() == "Address")
                {
                    this.addressBox.Text = "";
                }
            }

            else if (((TextBox)sender).Name.ToString() == "usernameRegister")
            {
                if (((TextBox)sender).Text.ToString() == "Username")
                {
                    this.usernameRegister.Text = "";
                }
            }
            else if (((TextBox)sender).Name.ToString() == "usernamefieldLogin")
            {
                if (((TextBox)sender).Text.ToString() == "Username")
                {
                    this.usernamefieldLogin.Text = "";
                }
            }
        }

        //to revert back to the placeholder text if user doesnt enter anything
        private void textboxes_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.ToString() == "")
            {
                if (((TextBox)sender).Name.ToString() == "nameBox")
                {
                    this.nameBox.Text = "Full name";
                }
                else if (((TextBox)sender).Name.ToString() == "codeBox")
                {
                    this.codeBox.Text = "Code";
                }
                else if (((TextBox)sender).Name.ToString() == "searchBox")
                {
                    this.searchBox.Text = "Search";
                }
                else if (((TextBox)sender).Name.ToString() == "numberBox")
                {
                    this.numberBox.Text = "Number";
                }
                else if (((TextBox)sender).Name.ToString() == "companyBox")
                {
                    this.companyBox.Text = "Company";
                }
                else if (((TextBox)sender).Name.ToString() == "jobtitleBox")
                {
                    this.jobtitleBox.Text = "Job Title";
                }
                else if (((TextBox)sender).Name.ToString() == "emailBox")
                {
                    this.emailBox.Text = "Email";
                }
                else if (((TextBox)sender).Name.ToString() == "addressBox")
                {
                    this.addressBox.Text = "Address";
                }
                else if (((TextBox)sender).Name.ToString() == "usernameRegister")
                {
                    this.usernameRegister.Text = "Username";
                }

                else if (((TextBox)sender).Name.ToString() == "usernamefieldLogin")
                {
                    this.usernamefieldLogin.Text = "Username";
                }

            }
        }

        //same window for creating new contact or editing the existing one
        private void EditorSave_btn_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content.ToString() == "Edit")//means when editing an already created contact
            {
                this.nameBox.Focusable = true;
                this.nameBox.IsReadOnly = false;

                this.codeBox.Focusable = true;
                this.codeBox.IsReadOnly = false;

                this.numberBox.Focusable = true;
                this.numberBox.IsReadOnly = false;

                this.companyBox.Focusable = true;
                this.companyBox.IsReadOnly = false;

                this.jobtitleBox.Focusable = true;
                this.jobtitleBox.IsReadOnly = false;

                this.emailBox.Focusable = true;
                this.emailBox.IsReadOnly = false;

                this.addressBox.Focusable = true;
                this.addressBox.IsReadOnly = false;

                String[] tokens = nameBox.Text.Split(' ');
                //updating the contents of the selected contact
                Contact item = (Contact)this.listItems.SelectedItem;
                if (tokens.Length == 1)
                {
                    item.firstName = tokens[0];
                    item.lastName = "";
                }
                else
                {
                    item.firstName = tokens[0];
                    item.lastName = tokens[1];
                }

                item.countryCode = codeBox.Text;
                item.phoneNo = numberBox.Text;
                item.photoAddress = filename;
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(item.photoAddress));
                photo.Fill = myBrush;

                item.Company = companyBox.Text;
                item.jobTitle = jobtitleBox.Text;
                item.Email = emailBox.Text;
                item.Address = addressBox.Text;

            }
            if (((Button)sender).Content.ToString() == "Save") //to save the new contact
            {
                String[] tokens = nameBox.Text.Split(' ');

                if (tokens.Length == 1)
                {   //creating new contact and assigning values
                    pb.addContact(new Contact()
                    {
                        firstName = tokens[0],
                        lastName = "",
                        countryCode = codeBox.Text,
                        phoneNo = numberBox.Text,
                        photoAddress = filename,
                        Company = companyBox.Text,
                        jobTitle = jobtitleBox.Text,
                        Email = emailBox.Text,
                        Address = addressBox.Text
                    });
                }
                else
                {
                    pb.addContact(new Contact()
                    {
                        firstName = tokens[0],
                        lastName = tokens[1],
                        countryCode = codeBox.Text,
                        phoneNo = numberBox.Text,
                        photoAddress = filename,
                        Company = companyBox.Text,
                        jobTitle = jobtitleBox.Text,
                        Email = emailBox.Text,
                        Address = addressBox.Text
                    });
                }


                this.nameBox.Focusable = false;
                this.nameBox.IsReadOnly = true;

                this.codeBox.Focusable = false;
                this.codeBox.IsReadOnly = true;

                this.numberBox.Focusable = false;
                this.numberBox.IsReadOnly = true;

                this.companyBox.Focusable = false;
                this.companyBox.IsReadOnly = true;

                this.jobtitleBox.Focusable = false;
                this.jobtitleBox.IsReadOnly = true;

                this.emailBox.Focusable = false;
                this.emailBox.IsReadOnly = true;

                this.addressBox.Focusable = false;
                this.addressBox.IsReadOnly = true;

                this.listItems.ItemsSource = null;
                this.listItems.ItemsSource = pb.getAll();

                registerGrid.Visibility = Visibility.Hidden;
                loginGrid.Visibility = Visibility.Hidden;
                addressbookGrid.Visibility = Visibility.Visible;
                profileGrid.Visibility = Visibility.Hidden;
            }
        }

        //to update/enter the contents of settings values
        private void Register_btn_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == passwordBox2.Password)
            {
                Properties.Settings.Default.Username = this.usernameRegister.Text.ToString();
                Properties.Settings.Default.Password = this.passwordBox.Password.ToString();

                Properties.Settings.Default.Save();

                MessageBox.Show("Account Registered");

                registerGrid.Visibility = Visibility.Hidden;
                loginGrid.Visibility = Visibility.Visible;

            }
            else
            {
                MessageBox.Show("Passwords mismatch!");
            }
        }
        //to go to login screen
        private void ClickhereRegister_Click(object sender, RoutedEventArgs e)
        {
            registerGrid.Visibility = Visibility.Hidden;
            loginGrid.Visibility = Visibility.Visible;
        }

        //to go to register screen
        private void ClickhereLogin_Click(object sender, RoutedEventArgs e)
        {
            registerGrid.Visibility = Visibility.Visible;
            loginGrid.Visibility = Visibility.Hidden;
        }

        //to authenticate login credentials and allow access to address book screen
        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            if (this.usernamefieldLogin.Text.ToString() == Properties.Settings.Default.Username
                && this.passwordBoxlogin.Password.ToString() == Properties.Settings.Default.Password)
            {
                registerGrid.Visibility = Visibility.Hidden;
                loginGrid.Visibility = Visibility.Hidden;
                addressbookGrid.Visibility = Visibility.Visible;
                profileGrid.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Wrong username/password!");
            }
        }

        //to go back to address book screen
        private void BackProfile_Click(object sender, RoutedEventArgs e)
        {
            registerGrid.Visibility = Visibility.Hidden;
            loginGrid.Visibility = Visibility.Hidden;
            addressbookGrid.Visibility = Visibility.Visible;
            profileGrid.Visibility = Visibility.Hidden;
        }

        //to create new contact and adding its details on the profile window
        private void CreatenewAddress_Click(object sender, RoutedEventArgs e)
        {

            this.delete_btn.Visibility = Visibility.Hidden;

            this.editorsave_btn.Content = "Save";

            this.nameBox.Focusable = true;
            this.nameBox.IsReadOnly = false;

            this.codeBox.Focusable = true;
            this.codeBox.IsReadOnly = false;

            this.numberBox.Focusable = true;
            this.numberBox.IsReadOnly = false;

            this.companyBox.Focusable = true;
            this.companyBox.IsReadOnly = false;

            this.jobtitleBox.Focusable = true;
            this.jobtitleBox.IsReadOnly = false;

            this.emailBox.Focusable = true;
            this.emailBox.IsReadOnly = false;

            this.addressBox.Focusable = true;
            this.addressBox.IsReadOnly = false;

            this.nameBox.Text = "Full name";
            this.codeBox.Text = "Code";
            this.numberBox.Text = "Number";
            this.companyBox.Text = "Company";
            this.jobtitleBox.Text = "Job Title";
            this.emailBox.Text = "Email";
            this.addressBox.Text = "Address";

            ImageBrush myBrush = new ImageBrush();
            filename = "D:\\Study\\6th Semester\\Visual Programming\\user.png";
            myBrush.ImageSource = new BitmapImage(new Uri(filename));
            photo.Fill = myBrush;

            registerGrid.Visibility = Visibility.Hidden;
            loginGrid.Visibility = Visibility.Hidden;
            addressbookGrid.Visibility = Visibility.Hidden;
            profileGrid.Visibility = Visibility.Visible;



        }

        //to insert user picture and update the filename variable
        private void Picedit_btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = fileDialog.FileName;
            }
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage(new Uri(filename));
            photo.Fill = myBrush;
        }


        //action listener for listening to double clicks on the contact to see its details
        private void ListItems_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.listItems.SelectedItem != null)
            {
                registerGrid.Visibility = Visibility.Hidden;
                loginGrid.Visibility = Visibility.Hidden;
                addressbookGrid.Visibility = Visibility.Hidden;
                profileGrid.Visibility = Visibility.Visible;

                this.editorsave_btn.Content = "Edit";
                this.delete_btn.Visibility = Visibility.Visible;
                Contact item = (Contact)this.listItems.SelectedItem;
                nameBox.Text = item.Fullname;
                codeBox.Text = item.countryCode;
                numberBox.Text = item.phoneNo;

                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(item.photoAddress));
                photo.Fill = myBrush;

                companyBox.Text = item.Company;
                jobtitleBox.Text = item.jobTitle;
                emailBox.Text = item.Email;
                addressBox.Text = item.Address;

            }
        }

        //to delete the existing contact
        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            Contact item = (Contact)this.listItems.SelectedItem;
            pb.deleteContact(item);

            registerGrid.Visibility = Visibility.Hidden;
            loginGrid.Visibility = Visibility.Hidden;
            addressbookGrid.Visibility = Visibility.Visible;
            profileGrid.Visibility = Visibility.Hidden;

        }

        //to search the list for the text in the search box
        //private void Search_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    if (search_btn.Content.ToString() == "Search")
        //    {
        //        if (pb[this.searchBox.Text] != null)
        //        {
        //            // Contact item = pb[this.searchBox.Text];
        //            listItems.ItemsSource = pb.getSearchList(this.searchBox.Text);
        //            search_btn.Content = "Reset";
        //        }
        //        else
        //        {
        //            MessageBox.Show("No contact found!");
        //        }
        //    } else if (search_btn.Content.ToString() == "Reset")
        //    {
        //        listItems.ItemsSource = pb.getAll();
        //        search_btn.Content = "Search";
        //        searchBox.Text = "Search";
        //        pb.searchList = new List<Contact>();
        //    }
        //}

        //to remove placeholder password when focused
        private void PasswordBox_GotFocus_1(object sender, RoutedEventArgs e)
        {
            if (((PasswordBox)sender).Name.ToString() == "passwordBox")
            {
                if (((PasswordBox)sender).Password.ToString() == "Password")
                {
                    this.passwordBox.Password = "";
                }
            }

            else if (((PasswordBox)sender).Name.ToString() == "passwordBox2")
            {
                if (((PasswordBox)sender).Password.ToString() == "Password")
                {
                    this.passwordBox2.Password = "";
                }
            }
            else if (((PasswordBox)sender).Name.ToString() == "passwordBoxlogin")
            {
                if (((PasswordBox)sender).Password.ToString() == "Password")
                {
                    this.passwordBoxlogin.Password = "";
                }
            }
        }


        //to revert back to placeholder password if user doesnt enter anything
        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((PasswordBox)sender).Password.ToString() == "")
            {
                if (((PasswordBox)sender).Name.ToString() == "Password")
                {
                    this.passwordBox2.Password = "Password";
                }

                else if (((PasswordBox)sender).Name.ToString() == "passwordBox")
                {
                    this.passwordBox.Password = "Password";
                }
                else if (((PasswordBox)sender).Name.ToString() == "passwordBoxlogin")
                {
                    this.passwordBoxlogin.Password = "Password";
                }
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (pb != null)
            {
                // Contact item = pb[this.searchBox.Text];
                listItems.ItemsSource = null;
                listItems.ItemsSource = pb.getSearchList(this.searchBox.Text);
                //search_btn.Content = "Reset";
            }
        }
    }
}
