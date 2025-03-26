namespace Movers_Booking_System.Forms
{
    partial class EstimateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelTopBar = new Panel();
            labelEstimate = new Label();
            buttonBack = new Button();
            panelLogo = new Panel();
            panelFormArea = new Panel();
            customButtonSubmit = new CustControlLib.CustomButton();
            panelForm = new Panel();
            pictureBoxAmountPaid = new PictureBox();
            pictureBoxItems = new PictureBox();
            pictureBoxRequirements = new PictureBox();
            pictureBoxBoxes = new PictureBox();
            pictureBoxRooms = new PictureBox();
            pictureBoxNewAddress = new PictureBox();
            pictureBoxOldAddress = new PictureBox();
            pictureBoxDate = new PictureBox();
            pictureBoxCustomer = new PictureBox();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            textBoxAmountPaid = new TextBox();
            customButtonRemoveSpecialItem = new CustControlLib.CustomButton();
            labelAmountPaid = new Label();
            label1 = new Label();
            checkBoxApartment = new CheckBox();
            customButtonAddSpecialItem = new CustControlLib.CustomButton();
            comboBoxSpecialItem = new ComboBox();
            labelItems = new Label();
            labelRequirements = new Label();
            labelFurniture = new Label();
            labelPacked = new Label();
            labelBoxes = new Label();
            labelRooms = new Label();
            labelNewAddress = new Label();
            labelOldAddress = new Label();
            labelDate = new Label();
            richTextBoxSpecialItems = new RichTextBox();
            richTextBoxExtraRequirements = new RichTextBox();
            checkBoxFurnitureAssembly = new CheckBox();
            checkBoxSelfPacked = new CheckBox();
            numericUpDownBoxes = new NumericUpDown();
            numericUpDownRooms = new NumericUpDown();
            richTextBoxNewAddress = new RichTextBox();
            richTextBoxOldAddress = new RichTextBox();
            dateTimePickerJobDate = new DateTimePicker();
            labelCustomer = new Label();
            comboBoxCustomer = new ComboBox();
            labelCreateEstimate = new Label();
            toolTip = new ToolTip(components);
            panelTopBar.SuspendLayout();
            panelFormArea.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAmountPaid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRequirements).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoxes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNewAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOldAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBoxes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRooms).BeginInit();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(labelEstimate);
            panelTopBar.Controls.Add(buttonBack);
            panelTopBar.Controls.Add(panelLogo);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1262, 100);
            panelTopBar.TabIndex = 3;
            // 
            // labelEstimate
            // 
            labelEstimate.AutoSize = true;
            labelEstimate.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelEstimate.ForeColor = Color.White;
            labelEstimate.Location = new Point(180, 25);
            labelEstimate.Name = "labelEstimate";
            labelEstimate.Size = new Size(283, 48);
            labelEstimate.TabIndex = 2;
            labelEstimate.Text = "Estimate Form";
            // 
            // buttonBack
            // 
            buttonBack.BackgroundImage = Media.SystemImages.back_button;
            buttonBack.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(1180, 20);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(60, 60);
            buttonBack.TabIndex = 1;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = Media.SystemImages.MOVERS_Logo___Dark;
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Location = new Point(0, -40);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(180, 180);
            panelLogo.TabIndex = 0;
            // 
            // panelFormArea
            // 
            panelFormArea.AutoScroll = true;
            panelFormArea.Controls.Add(customButtonSubmit);
            panelFormArea.Controls.Add(panelForm);
            panelFormArea.Dock = DockStyle.Fill;
            panelFormArea.Location = new Point(0, 100);
            panelFormArea.Name = "panelFormArea";
            panelFormArea.Size = new Size(1262, 644);
            panelFormArea.TabIndex = 4;
            // 
            // customButtonSubmit
            // 
            customButtonSubmit.BackColor = Color.FromArgb(30, 125, 187);
            customButtonSubmit.BorderColor = Color.Black;
            customButtonSubmit.BorderRadius = 40;
            customButtonSubmit.BorderWidth = 0;
            customButtonSubmit.FlatAppearance.BorderSize = 0;
            customButtonSubmit.FlatStyle = FlatStyle.Flat;
            customButtonSubmit.Font = new Font("Bahnschrift", 12F);
            customButtonSubmit.ForeColor = Color.White;
            customButtonSubmit.Location = new Point(1066, 552);
            customButtonSubmit.Name = "customButtonSubmit";
            customButtonSubmit.Size = new Size(115, 50);
            customButtonSubmit.TabIndex = 15;
            customButtonSubmit.Text = "Submit";
            customButtonSubmit.UseVisualStyleBackColor = false;
            customButtonSubmit.Click += customButtonSubmit_Click;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(30, 125, 187);
            panelForm.Controls.Add(pictureBoxAmountPaid);
            panelForm.Controls.Add(pictureBoxItems);
            panelForm.Controls.Add(pictureBoxRequirements);
            panelForm.Controls.Add(pictureBoxBoxes);
            panelForm.Controls.Add(pictureBoxRooms);
            panelForm.Controls.Add(pictureBoxNewAddress);
            panelForm.Controls.Add(pictureBoxOldAddress);
            panelForm.Controls.Add(pictureBoxDate);
            panelForm.Controls.Add(pictureBoxCustomer);
            panelForm.Controls.Add(textBoxPrice);
            panelForm.Controls.Add(labelPrice);
            panelForm.Controls.Add(textBoxAmountPaid);
            panelForm.Controls.Add(customButtonRemoveSpecialItem);
            panelForm.Controls.Add(labelAmountPaid);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(checkBoxApartment);
            panelForm.Controls.Add(customButtonAddSpecialItem);
            panelForm.Controls.Add(comboBoxSpecialItem);
            panelForm.Controls.Add(labelItems);
            panelForm.Controls.Add(labelRequirements);
            panelForm.Controls.Add(labelFurniture);
            panelForm.Controls.Add(labelPacked);
            panelForm.Controls.Add(labelBoxes);
            panelForm.Controls.Add(labelRooms);
            panelForm.Controls.Add(labelNewAddress);
            panelForm.Controls.Add(labelOldAddress);
            panelForm.Controls.Add(labelDate);
            panelForm.Controls.Add(richTextBoxSpecialItems);
            panelForm.Controls.Add(richTextBoxExtraRequirements);
            panelForm.Controls.Add(checkBoxFurnitureAssembly);
            panelForm.Controls.Add(checkBoxSelfPacked);
            panelForm.Controls.Add(numericUpDownBoxes);
            panelForm.Controls.Add(numericUpDownRooms);
            panelForm.Controls.Add(richTextBoxNewAddress);
            panelForm.Controls.Add(richTextBoxOldAddress);
            panelForm.Controls.Add(dateTimePickerJobDate);
            panelForm.Controls.Add(labelCustomer);
            panelForm.Controls.Add(comboBoxCustomer);
            panelForm.Controls.Add(labelCreateEstimate);
            panelForm.Location = new Point(81, 60);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1100, 486);
            panelForm.TabIndex = 0;
            // 
            // pictureBoxAmountPaid
            // 
            pictureBoxAmountPaid.Image = Media.SystemImages.question;
            pictureBoxAmountPaid.Location = new Point(926, 373);
            pictureBoxAmountPaid.Name = "pictureBoxAmountPaid";
            pictureBoxAmountPaid.Size = new Size(20, 20);
            pictureBoxAmountPaid.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAmountPaid.TabIndex = 111;
            pictureBoxAmountPaid.TabStop = false;
            toolTip.SetToolTip(pictureBoxAmountPaid, "Amount paid must be greater than the 50% deposit");
            // 
            // pictureBoxItems
            // 
            pictureBoxItems.Image = Media.SystemImages.question;
            pictureBoxItems.Location = new Point(1047, 172);
            pictureBoxItems.Name = "pictureBoxItems";
            pictureBoxItems.Size = new Size(20, 20);
            pictureBoxItems.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxItems.TabIndex = 110;
            pictureBoxItems.TabStop = false;
            toolTip.SetToolTip(pictureBoxItems, "Select preexisting special item");
            // 
            // pictureBoxRequirements
            // 
            pictureBoxRequirements.Image = Media.SystemImages.question;
            pictureBoxRequirements.Location = new Point(1047, 75);
            pictureBoxRequirements.Name = "pictureBoxRequirements";
            pictureBoxRequirements.Size = new Size(20, 20);
            pictureBoxRequirements.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRequirements.TabIndex = 109;
            pictureBoxRequirements.TabStop = false;
            toolTip.SetToolTip(pictureBoxRequirements, "Extra information for moving staff");
            // 
            // pictureBoxBoxes
            // 
            pictureBoxBoxes.Image = Media.SystemImages.question;
            pictureBoxBoxes.Location = new Point(313, 358);
            pictureBoxBoxes.Name = "pictureBoxBoxes";
            pictureBoxBoxes.Size = new Size(20, 20);
            pictureBoxBoxes.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBoxes.TabIndex = 108;
            pictureBoxBoxes.TabStop = false;
            toolTip.SetToolTip(pictureBoxBoxes, "Must be in increments of 10 boxes");
            // 
            // pictureBoxRooms
            // 
            pictureBoxRooms.Image = Media.SystemImages.question;
            pictureBoxRooms.Location = new Point(313, 321);
            pictureBoxRooms.Name = "pictureBoxRooms";
            pictureBoxRooms.Size = new Size(20, 20);
            pictureBoxRooms.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRooms.TabIndex = 107;
            pictureBoxRooms.TabStop = false;
            toolTip.SetToolTip(pictureBoxRooms, "For a house must be between 1 and 4. For an apartment must be between 1 and 2");
            // 
            // pictureBoxNewAddress
            // 
            pictureBoxNewAddress.Image = Media.SystemImages.question;
            pictureBoxNewAddress.Location = new Point(520, 238);
            pictureBoxNewAddress.Name = "pictureBoxNewAddress";
            pictureBoxNewAddress.Size = new Size(20, 20);
            pictureBoxNewAddress.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNewAddress.TabIndex = 106;
            pictureBoxNewAddress.TabStop = false;
            toolTip.SetToolTip(pictureBoxNewAddress, "Must only contain letters, numbers and punctuation");
            // 
            // pictureBoxOldAddress
            // 
            pictureBoxOldAddress.Image = Media.SystemImages.question;
            pictureBoxOldAddress.Location = new Point(520, 154);
            pictureBoxOldAddress.Name = "pictureBoxOldAddress";
            pictureBoxOldAddress.Size = new Size(20, 20);
            pictureBoxOldAddress.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOldAddress.TabIndex = 105;
            pictureBoxOldAddress.TabStop = false;
            toolTip.SetToolTip(pictureBoxOldAddress, "Must only contain letters, numbers and punctuation");
            // 
            // pictureBoxDate
            // 
            pictureBoxDate.Image = Media.SystemImages.question;
            pictureBoxDate.Location = new Point(520, 116);
            pictureBoxDate.Name = "pictureBoxDate";
            pictureBoxDate.Size = new Size(20, 20);
            pictureBoxDate.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDate.TabIndex = 104;
            pictureBoxDate.TabStop = false;
            toolTip.SetToolTip(pictureBoxDate, "Christmas and Easter Holidays cannot be selected. Sundays and public holidays incur an extra cost");
            // 
            // pictureBoxCustomer
            // 
            pictureBoxCustomer.Image = Media.SystemImages.question;
            pictureBoxCustomer.Location = new Point(520, 75);
            pictureBoxCustomer.Name = "pictureBoxCustomer";
            pictureBoxCustomer.Size = new Size(20, 20);
            pictureBoxCustomer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCustomer.TabIndex = 103;
            pictureBoxCustomer.TabStop = false;
            toolTip.SetToolTip(pictureBoxCustomer, "Select Existing Customer");
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Bahnschrift", 9F);
            textBoxPrice.Location = new Point(761, 414);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(159, 26);
            textBoxPrice.TabIndex = 102;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = Color.White;
            labelPrice.Location = new Point(623, 416);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(128, 24);
            labelPrice.TabIndex = 101;
            labelPrice.Text = "Total Price  £";
            // 
            // textBoxAmountPaid
            // 
            textBoxAmountPaid.Font = new Font("Bahnschrift", 9F);
            textBoxAmountPaid.Location = new Point(761, 369);
            textBoxAmountPaid.Name = "textBoxAmountPaid";
            textBoxAmountPaid.Size = new Size(159, 26);
            textBoxAmountPaid.TabIndex = 14;
            // 
            // customButtonRemoveSpecialItem
            // 
            customButtonRemoveSpecialItem.BackColor = Color.White;
            customButtonRemoveSpecialItem.BorderColor = Color.Black;
            customButtonRemoveSpecialItem.BorderRadius = 29;
            customButtonRemoveSpecialItem.BorderWidth = 0;
            customButtonRemoveSpecialItem.FlatAppearance.BorderSize = 0;
            customButtonRemoveSpecialItem.FlatStyle = FlatStyle.Flat;
            customButtonRemoveSpecialItem.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButtonRemoveSpecialItem.ForeColor = Color.Black;
            customButtonRemoveSpecialItem.Location = new Point(821, 200);
            customButtonRemoveSpecialItem.Name = "customButtonRemoveSpecialItem";
            customButtonRemoveSpecialItem.Size = new Size(78, 29);
            customButtonRemoveSpecialItem.TabIndex = 13;
            customButtonRemoveSpecialItem.Text = "Remove";
            customButtonRemoveSpecialItem.UseVisualStyleBackColor = false;
            customButtonRemoveSpecialItem.Click += customButtonRemoveSpecialItem_Click;
            // 
            // labelAmountPaid
            // 
            labelAmountPaid.AutoSize = true;
            labelAmountPaid.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAmountPaid.ForeColor = Color.White;
            labelAmountPaid.Location = new Point(604, 369);
            labelAmountPaid.Name = "labelAmountPaid";
            labelAmountPaid.Size = new Size(151, 24);
            labelAmountPaid.TabIndex = 30;
            labelAmountPaid.Text = "Amount Paid   £";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 416);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 28;
            label1.Text = "Apartment";
            // 
            // checkBoxApartment
            // 
            checkBoxApartment.AutoSize = true;
            checkBoxApartment.Font = new Font("Bahnschrift", 9F);
            checkBoxApartment.Location = new Point(237, 420);
            checkBoxApartment.Name = "checkBoxApartment";
            checkBoxApartment.Size = new Size(18, 17);
            checkBoxApartment.TabIndex = 8;
            checkBoxApartment.UseVisualStyleBackColor = true;
            checkBoxApartment.CheckedChanged += checkBoxApartment_CheckedChanged;
            // 
            // customButtonAddSpecialItem
            // 
            customButtonAddSpecialItem.BackColor = Color.White;
            customButtonAddSpecialItem.BorderColor = Color.Black;
            customButtonAddSpecialItem.BorderRadius = 29;
            customButtonAddSpecialItem.BorderWidth = 0;
            customButtonAddSpecialItem.FlatAppearance.BorderSize = 0;
            customButtonAddSpecialItem.FlatStyle = FlatStyle.Flat;
            customButtonAddSpecialItem.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButtonAddSpecialItem.ForeColor = Color.Black;
            customButtonAddSpecialItem.Location = new Point(761, 200);
            customButtonAddSpecialItem.Name = "customButtonAddSpecialItem";
            customButtonAddSpecialItem.Size = new Size(57, 29);
            customButtonAddSpecialItem.TabIndex = 12;
            customButtonAddSpecialItem.Text = "Add";
            customButtonAddSpecialItem.UseVisualStyleBackColor = false;
            customButtonAddSpecialItem.Click += customButtonAddSpecialItem_Click;
            // 
            // comboBoxSpecialItem
            // 
            comboBoxSpecialItem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecialItem.Font = new Font("Bahnschrift", 9F);
            comboBoxSpecialItem.FormattingEnabled = true;
            comboBoxSpecialItem.Location = new Point(761, 168);
            comboBoxSpecialItem.Name = "comboBoxSpecialItem";
            comboBoxSpecialItem.Size = new Size(280, 26);
            comboBoxSpecialItem.TabIndex = 11;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelItems.ForeColor = Color.White;
            labelItems.Location = new Point(623, 168);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(132, 24);
            labelItems.TabIndex = 24;
            labelItems.Text = "Special Items";
            // 
            // labelRequirements
            // 
            labelRequirements.AutoSize = true;
            labelRequirements.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRequirements.ForeColor = Color.White;
            labelRequirements.Location = new Point(564, 72);
            labelRequirements.Name = "labelRequirements";
            labelRequirements.Size = new Size(191, 24);
            labelRequirements.TabIndex = 23;
            labelRequirements.Text = "Extra Requirements";
            // 
            // labelFurniture
            // 
            labelFurniture.AutoSize = true;
            labelFurniture.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFurniture.ForeColor = Color.White;
            labelFurniture.Location = new Point(30, 443);
            labelFurniture.Name = "labelFurniture";
            labelFurniture.Size = new Size(188, 24);
            labelFurniture.TabIndex = 22;
            labelFurniture.Text = "Furniture Assembly";
            // 
            // labelPacked
            // 
            labelPacked.AutoSize = true;
            labelPacked.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPacked.ForeColor = Color.White;
            labelPacked.Location = new Point(97, 390);
            labelPacked.Name = "labelPacked";
            labelPacked.Size = new Size(121, 24);
            labelPacked.TabIndex = 21;
            labelPacked.Text = "Self-Packed";
            // 
            // labelBoxes
            // 
            labelBoxes.AutoSize = true;
            labelBoxes.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBoxes.ForeColor = Color.White;
            labelBoxes.Location = new Point(20, 356);
            labelBoxes.Name = "labelBoxes";
            labelBoxes.Size = new Size(198, 24);
            labelBoxes.TabIndex = 20;
            labelBoxes.Text = "No. of Packing Boxes";
            // 
            // labelRooms
            // 
            labelRooms.AutoSize = true;
            labelRooms.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRooms.ForeColor = Color.White;
            labelRooms.Location = new Point(89, 319);
            labelRooms.Name = "labelRooms";
            labelRooms.Size = new Size(129, 24);
            labelRooms.TabIndex = 19;
            labelRooms.Text = "No. of Rooms";
            // 
            // labelNewAddress
            // 
            labelNewAddress.AutoSize = true;
            labelNewAddress.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewAddress.ForeColor = Color.White;
            labelNewAddress.Location = new Point(88, 234);
            labelNewAddress.Name = "labelNewAddress";
            labelNewAddress.Size = new Size(130, 24);
            labelNewAddress.TabIndex = 18;
            labelNewAddress.Text = "New Address";
            // 
            // labelOldAddress
            // 
            labelOldAddress.AutoSize = true;
            labelOldAddress.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOldAddress.ForeColor = Color.White;
            labelOldAddress.Location = new Point(98, 150);
            labelOldAddress.Name = "labelOldAddress";
            labelOldAddress.Size = new Size(120, 24);
            labelOldAddress.TabIndex = 17;
            labelOldAddress.Text = "Old Address";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(166, 112);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(52, 24);
            labelDate.TabIndex = 16;
            labelDate.Text = "Date";
            // 
            // richTextBoxSpecialItems
            // 
            richTextBoxSpecialItems.Font = new Font("Bahnschrift", 9F);
            richTextBoxSpecialItems.Location = new Point(761, 236);
            richTextBoxSpecialItems.Name = "richTextBoxSpecialItems";
            richTextBoxSpecialItems.ReadOnly = true;
            richTextBoxSpecialItems.Size = new Size(280, 117);
            richTextBoxSpecialItems.TabIndex = 100;
            richTextBoxSpecialItems.Text = "";
            // 
            // richTextBoxExtraRequirements
            // 
            richTextBoxExtraRequirements.Font = new Font("Bahnschrift", 9F);
            richTextBoxExtraRequirements.Location = new Point(761, 72);
            richTextBoxExtraRequirements.Name = "richTextBoxExtraRequirements";
            richTextBoxExtraRequirements.Size = new Size(280, 74);
            richTextBoxExtraRequirements.TabIndex = 10;
            richTextBoxExtraRequirements.Text = "";
            // 
            // checkBoxFurnitureAssembly
            // 
            checkBoxFurnitureAssembly.AutoSize = true;
            checkBoxFurnitureAssembly.Font = new Font("Bahnschrift", 9F);
            checkBoxFurnitureAssembly.Location = new Point(237, 447);
            checkBoxFurnitureAssembly.Name = "checkBoxFurnitureAssembly";
            checkBoxFurnitureAssembly.Size = new Size(18, 17);
            checkBoxFurnitureAssembly.TabIndex = 9;
            checkBoxFurnitureAssembly.UseVisualStyleBackColor = true;
            // 
            // checkBoxSelfPacked
            // 
            checkBoxSelfPacked.AutoSize = true;
            checkBoxSelfPacked.Font = new Font("Bahnschrift", 9F);
            checkBoxSelfPacked.Location = new Point(237, 394);
            checkBoxSelfPacked.Name = "checkBoxSelfPacked";
            checkBoxSelfPacked.Size = new Size(18, 17);
            checkBoxSelfPacked.TabIndex = 7;
            checkBoxSelfPacked.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBoxes
            // 
            numericUpDownBoxes.Font = new Font("Bahnschrift", 9F);
            numericUpDownBoxes.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownBoxes.Location = new Point(237, 355);
            numericUpDownBoxes.Name = "numericUpDownBoxes";
            numericUpDownBoxes.Size = new Size(65, 26);
            numericUpDownBoxes.TabIndex = 6;
            numericUpDownBoxes.ValueChanged += numericUpDownBoxes_ValueChanged;
            // 
            // numericUpDownRooms
            // 
            numericUpDownRooms.Font = new Font("Bahnschrift", 9F);
            numericUpDownRooms.Location = new Point(237, 318);
            numericUpDownRooms.Name = "numericUpDownRooms";
            numericUpDownRooms.Size = new Size(65, 26);
            numericUpDownRooms.TabIndex = 5;
            // 
            // richTextBoxNewAddress
            // 
            richTextBoxNewAddress.Font = new Font("Bahnschrift", 9F);
            richTextBoxNewAddress.Location = new Point(237, 234);
            richTextBoxNewAddress.Name = "richTextBoxNewAddress";
            richTextBoxNewAddress.Size = new Size(277, 74);
            richTextBoxNewAddress.TabIndex = 4;
            richTextBoxNewAddress.Text = "";
            // 
            // richTextBoxOldAddress
            // 
            richTextBoxOldAddress.Font = new Font("Bahnschrift", 9F);
            richTextBoxOldAddress.Location = new Point(237, 150);
            richTextBoxOldAddress.Name = "richTextBoxOldAddress";
            richTextBoxOldAddress.Size = new Size(277, 74);
            richTextBoxOldAddress.TabIndex = 3;
            richTextBoxOldAddress.Text = "";
            // 
            // dateTimePickerJobDate
            // 
            dateTimePickerJobDate.Font = new Font("Bahnschrift", 9F);
            dateTimePickerJobDate.Location = new Point(237, 112);
            dateTimePickerJobDate.Name = "dateTimePickerJobDate";
            dateTimePickerJobDate.Size = new Size(277, 26);
            dateTimePickerJobDate.TabIndex = 2;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomer.ForeColor = Color.White;
            labelCustomer.Location = new Point(120, 72);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(98, 24);
            labelCustomer.TabIndex = 5;
            labelCustomer.Text = "Customer";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.Font = new Font("Bahnschrift", 9F);
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(237, 72);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(277, 26);
            comboBoxCustomer.TabIndex = 1;
            // 
            // labelCreateEstimate
            // 
            labelCreateEstimate.AutoSize = true;
            labelCreateEstimate.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            labelCreateEstimate.ForeColor = Color.White;
            labelCreateEstimate.Location = new Point(20, 20);
            labelCreateEstimate.Name = "labelCreateEstimate";
            labelCreateEstimate.Size = new Size(338, 41);
            labelCreateEstimate.TabIndex = 3;
            labelCreateEstimate.Text = "Create New Estimate";
            // 
            // EstimateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(panelFormArea);
            Controls.Add(panelTopBar);
            Name = "EstimateForm";
            Text = "EstimateForm";
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelFormArea.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAmountPaid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRequirements).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoxes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNewAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOldAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBoxes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Panel panelLogo;
        private Button buttonBack;
        private Panel panelFormArea;
        private Panel panelForm;
        private Label labelEstimate;
        private CustControlLib.CustomButton customButtonSubmit;
        private Label labelCreateEstimate;
        private Label labelCustomer;
        private ComboBox comboBoxCustomer;
        private DateTimePicker dateTimePickerJobDate;
        private RichTextBox richTextBoxNewAddress;
        private RichTextBox richTextBoxOldAddress;
        private NumericUpDown numericUpDownBoxes;
        private NumericUpDown numericUpDownRooms;
        private CheckBox checkBoxSelfPacked;
        private CheckBox checkBoxFurnitureAssembly;
        private RichTextBox richTextBoxExtraRequirements;
        private Label labelBoxes;
        private Label labelRooms;
        private Label labelNewAddress;
        private Label labelOldAddress;
        private Label labelDate;
        private RichTextBox richTextBoxSpecialItems;
        private ComboBox comboBoxSpecialItem;
        private Label labelItems;
        private Label labelRequirements;
        private Label labelFurniture;
        private Label labelPacked;
        private CustControlLib.CustomButton customButtonAddSpecialItem;
        private Label label1;
        private CheckBox checkBoxApartment;
        private Label labelAmountPaid;
        private CustControlLib.CustomButton customButtonRemoveSpecialItem;
        private TextBox textBoxAmountPaid;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private PictureBox pictureBoxAmountPaid;
        private PictureBox pictureBoxItems;
        private PictureBox pictureBoxRequirements;
        private PictureBox pictureBoxBoxes;
        private PictureBox pictureBoxRooms;
        private PictureBox pictureBoxNewAddress;
        private PictureBox pictureBoxOldAddress;
        private PictureBox pictureBoxDate;
        private PictureBox pictureBoxCustomer;
        private ToolTip toolTip;
    }
}