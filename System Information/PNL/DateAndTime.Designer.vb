<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DateAndTime
    Inherits SystemInformation.TaskPanelBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LabelTitle = New System.Windows.Forms.Label
        Me.PictureBoxPanel = New System.Windows.Forms.PictureBox
        Me.LabelLocalDateTime = New System.Windows.Forms.Label
        Me.LabelOffsetFromUTC = New System.Windows.Forms.Label
        Me.LabelTimeZone = New System.Windows.Forms.Label
        Me.LabelSeparator = New System.Windows.Forms.Label
        Me.LabelUniversal = New System.Windows.Forms.Label
        Me.LabelUniversalDateTime = New System.Windows.Forms.Label
        Me.LabelLocal = New System.Windows.Forms.Label
        Me.LabelDaylightEnd = New System.Windows.Forms.Label
        Me.LabelDaylightStart = New System.Windows.Forms.Label
        Me.LabelSeparaterBottom = New System.Windows.Forms.Label
        Me.TimerDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.LabelOffset = New System.Windows.Forms.Label
        Me.LabelDaylightStartDesc = New System.Windows.Forms.Label
        Me.LabelDaylightEndDesc = New System.Windows.Forms.Label
        Me.MonthCalendarDateTime = New System.Windows.Forms.MonthCalendar
        Me.LabelSelectedWeekOfYear = New System.Windows.Forms.Label
        Me.LabelSelectedWeeksLeft = New System.Windows.Forms.Label
        Me.LabelSelectedWeekOfYearDesc = New System.Windows.Forms.Label
        Me.LabelSelectedWeeksLeftDesc = New System.Windows.Forms.Label
        Me.LabelCurrentWeekOfYear = New System.Windows.Forms.Label
        Me.LabelCurrentWeeksLeft = New System.Windows.Forms.Label
        Me.LabelCurrentWeekOfYearDesc = New System.Windows.Forms.Label
        Me.LabelCurrentWeeksLeftDesc = New System.Windows.Forms.Label
        Me.LabelSelectedDate = New System.Windows.Forms.Label
        Me.LabelSelectedDayOfYear = New System.Windows.Forms.Label
        Me.LabelSelectedDaysLeft = New System.Windows.Forms.Label
        Me.LabelOffsetFromToday = New System.Windows.Forms.Label
        Me.labelSelectedHoliday = New System.Windows.Forms.Label
        Me.LabelSelectedDayOfYearDesc = New System.Windows.Forms.Label
        Me.LabelSelectedDaysLeftDesc = New System.Windows.Forms.Label
        Me.LabelOffsetFromTodayDesc = New System.Windows.Forms.Label
        Me.LabelSelectedDateDesc = New System.Windows.Forms.Label
        Me.LabelTCurrentDateDesc = New System.Windows.Forms.Label
        Me.LabelCurrentDayOfYear = New System.Windows.Forms.Label
        Me.LabelCurrentDaysLeft = New System.Windows.Forms.Label
        Me.LabelCurrentHoliday = New System.Windows.Forms.Label
        Me.LabelCurrentDayOfYearDesc = New System.Windows.Forms.Label
        Me.LabelCurrentDaysLeftDesc = New System.Windows.Forms.Label
        Me.LabelCurrentDate = New System.Windows.Forms.Label
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelTitle.Location = New System.Drawing.Point(80, 28)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(140, 25)
        Me.LabelTitle.TabIndex = 3
        Me.LabelTitle.Text = "Date and Time"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.SystemInformation.My.Resources.Resources.Date_Time_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 2
        Me.PictureBoxPanel.TabStop = False
        '
        'LabelLocalDateTime
        '
        Me.LabelLocalDateTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelLocalDateTime.Location = New System.Drawing.Point(192, 124)
        Me.LabelLocalDateTime.Name = "LabelLocalDateTime"
        Me.LabelLocalDateTime.Size = New System.Drawing.Size(260, 15)
        Me.LabelLocalDateTime.TabIndex = 19
        '
        'LabelOffsetFromUTC
        '
        Me.LabelOffsetFromUTC.BackColor = System.Drawing.Color.Transparent
        Me.LabelOffsetFromUTC.Location = New System.Drawing.Point(192, 104)
        Me.LabelOffsetFromUTC.Name = "LabelOffsetFromUTC"
        Me.LabelOffsetFromUTC.Size = New System.Drawing.Size(260, 15)
        Me.LabelOffsetFromUTC.TabIndex = 18
        '
        'LabelTimeZone
        '
        Me.LabelTimeZone.BackColor = System.Drawing.Color.Transparent
        Me.LabelTimeZone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelTimeZone.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelTimeZone.Location = New System.Drawing.Point(80, 72)
        Me.LabelTimeZone.Name = "LabelTimeZone"
        Me.LabelTimeZone.Size = New System.Drawing.Size(420, 17)
        Me.LabelTimeZone.TabIndex = 17
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator.Location = New System.Drawing.Point(16, 94)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(482, 3)
        Me.LabelSeparator.TabIndex = 15
        '
        'LabelUniversal
        '
        Me.LabelUniversal.BackColor = System.Drawing.Color.Transparent
        Me.LabelUniversal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelUniversal.Location = New System.Drawing.Point(32, 144)
        Me.LabelUniversal.Name = "LabelUniversal"
        Me.LabelUniversal.Size = New System.Drawing.Size(156, 15)
        Me.LabelUniversal.TabIndex = 20
        Me.LabelUniversal.Text = "Universal Date and Time:"
        '
        'LabelUniversalDateTime
        '
        Me.LabelUniversalDateTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelUniversalDateTime.Location = New System.Drawing.Point(192, 144)
        Me.LabelUniversalDateTime.Name = "LabelUniversalDateTime"
        Me.LabelUniversalDateTime.Size = New System.Drawing.Size(260, 15)
        Me.LabelUniversalDateTime.TabIndex = 21
        '
        'LabelLocal
        '
        Me.LabelLocal.BackColor = System.Drawing.Color.Transparent
        Me.LabelLocal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelLocal.Location = New System.Drawing.Point(32, 124)
        Me.LabelLocal.Name = "LabelLocal"
        Me.LabelLocal.Size = New System.Drawing.Size(156, 15)
        Me.LabelLocal.TabIndex = 23
        Me.LabelLocal.Text = "Local Date and Time:"
        '
        'LabelDaylightEnd
        '
        Me.LabelDaylightEnd.BackColor = System.Drawing.Color.Transparent
        Me.LabelDaylightEnd.Location = New System.Drawing.Point(192, 184)
        Me.LabelDaylightEnd.Name = "LabelDaylightEnd"
        Me.LabelDaylightEnd.Size = New System.Drawing.Size(260, 15)
        Me.LabelDaylightEnd.TabIndex = 29
        '
        'LabelDaylightStart
        '
        Me.LabelDaylightStart.BackColor = System.Drawing.Color.Transparent
        Me.LabelDaylightStart.Location = New System.Drawing.Point(192, 164)
        Me.LabelDaylightStart.Name = "LabelDaylightStart"
        Me.LabelDaylightStart.Size = New System.Drawing.Size(260, 15)
        Me.LabelDaylightStart.TabIndex = 26
        '
        'LabelSeparaterBottom
        '
        Me.LabelSeparaterBottom.BackColor = System.Drawing.Color.Black
        Me.LabelSeparaterBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparaterBottom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparaterBottom.Location = New System.Drawing.Point(16, 214)
        Me.LabelSeparaterBottom.Name = "LabelSeparaterBottom"
        Me.LabelSeparaterBottom.Size = New System.Drawing.Size(482, 3)
        Me.LabelSeparaterBottom.TabIndex = 24
        '
        'TimerDateTime
        '
        Me.TimerDateTime.Interval = 1000
        '
        'LabelOffset
        '
        Me.LabelOffset.BackColor = System.Drawing.Color.Transparent
        Me.LabelOffset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelOffset.Location = New System.Drawing.Point(32, 104)
        Me.LabelOffset.Name = "LabelOffset"
        Me.LabelOffset.Size = New System.Drawing.Size(156, 15)
        Me.LabelOffset.TabIndex = 34
        Me.LabelOffset.Text = "Offset from Univeral Time:"
        '
        'LabelDaylightStartDesc
        '
        Me.LabelDaylightStartDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelDaylightStartDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelDaylightStartDesc.Location = New System.Drawing.Point(32, 164)
        Me.LabelDaylightStartDesc.Name = "LabelDaylightStartDesc"
        Me.LabelDaylightStartDesc.Size = New System.Drawing.Size(156, 15)
        Me.LabelDaylightStartDesc.TabIndex = 36
        Me.LabelDaylightStartDesc.Text = "Daylight Savings Start:"
        '
        'LabelDaylightEndDesc
        '
        Me.LabelDaylightEndDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelDaylightEndDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelDaylightEndDesc.Location = New System.Drawing.Point(32, 184)
        Me.LabelDaylightEndDesc.Name = "LabelDaylightEndDesc"
        Me.LabelDaylightEndDesc.Size = New System.Drawing.Size(156, 15)
        Me.LabelDaylightEndDesc.TabIndex = 38
        Me.LabelDaylightEndDesc.Text = "Daylight Savings End: "
        '
        'MonthCalendarDateTime
        '
        Me.MonthCalendarDateTime.Location = New System.Drawing.Point(32, 224)
        Me.MonthCalendarDateTime.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendarDateTime.MaxSelectionCount = 1
        Me.MonthCalendarDateTime.MinDate = New Date(1776, 7, 1, 0, 0, 0, 0)
        Me.MonthCalendarDateTime.Name = "MonthCalendarDateTime"
        Me.MonthCalendarDateTime.ShowToday = False
        Me.MonthCalendarDateTime.TabIndex = 39
        Me.MonthCalendarDateTime.TitleBackColor = System.Drawing.Color.DarkGreen
        '
        'LabelSelectedWeekOfYear
        '
        Me.LabelSelectedWeekOfYear.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectedWeekOfYear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSelectedWeekOfYear.Location = New System.Drawing.Point(476, 336)
        Me.LabelSelectedWeekOfYear.Name = "LabelSelectedWeekOfYear"
        Me.LabelSelectedWeekOfYear.Size = New System.Drawing.Size(24, 15)
        Me.LabelSelectedWeekOfYear.TabIndex = 110
        Me.LabelSelectedWeekOfYear.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelSelectedWeeksLeft
        '
        Me.LabelSelectedWeeksLeft.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectedWeeksLeft.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSelectedWeeksLeft.Location = New System.Drawing.Point(476, 356)
        Me.LabelSelectedWeeksLeft.Name = "LabelSelectedWeeksLeft"
        Me.LabelSelectedWeeksLeft.Size = New System.Drawing.Size(24, 15)
        Me.LabelSelectedWeeksLeft.TabIndex = 109
        Me.LabelSelectedWeeksLeft.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelSelectedWeekOfYearDesc
        '
        Me.LabelSelectedWeekOfYearDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectedWeekOfYearDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSelectedWeekOfYearDesc.Location = New System.Drawing.Point(392, 336)
        Me.LabelSelectedWeekOfYearDesc.Name = "LabelSelectedWeekOfYearDesc"
        Me.LabelSelectedWeekOfYearDesc.Size = New System.Drawing.Size(80, 15)
        Me.LabelSelectedWeekOfYearDesc.TabIndex = 108
        Me.LabelSelectedWeekOfYearDesc.Text = "Week of Year:"
        '
        'LabelSelectedWeeksLeftDesc
        '
        Me.LabelSelectedWeeksLeftDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectedWeeksLeftDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSelectedWeeksLeftDesc.Location = New System.Drawing.Point(392, 356)
        Me.LabelSelectedWeeksLeftDesc.Name = "LabelSelectedWeeksLeftDesc"
        Me.LabelSelectedWeeksLeftDesc.Size = New System.Drawing.Size(80, 15)
        Me.LabelSelectedWeeksLeftDesc.TabIndex = 107
        Me.LabelSelectedWeeksLeftDesc.Text = "Weeks Left:"
        '
        'LabelCurrentWeekOfYear
        '
        Me.LabelCurrentWeekOfYear.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentWeekOfYear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCurrentWeekOfYear.Location = New System.Drawing.Point(476, 244)
        Me.LabelCurrentWeekOfYear.Name = "LabelCurrentWeekOfYear"
        Me.LabelCurrentWeekOfYear.Size = New System.Drawing.Size(24, 15)
        Me.LabelCurrentWeekOfYear.TabIndex = 106
        Me.LabelCurrentWeekOfYear.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCurrentWeeksLeft
        '
        Me.LabelCurrentWeeksLeft.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentWeeksLeft.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCurrentWeeksLeft.Location = New System.Drawing.Point(476, 264)
        Me.LabelCurrentWeeksLeft.Name = "LabelCurrentWeeksLeft"
        Me.LabelCurrentWeeksLeft.Size = New System.Drawing.Size(24, 15)
        Me.LabelCurrentWeeksLeft.TabIndex = 105
        Me.LabelCurrentWeeksLeft.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCurrentWeekOfYearDesc
        '
        Me.LabelCurrentWeekOfYearDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentWeekOfYearDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCurrentWeekOfYearDesc.Location = New System.Drawing.Point(392, 244)
        Me.LabelCurrentWeekOfYearDesc.Name = "LabelCurrentWeekOfYearDesc"
        Me.LabelCurrentWeekOfYearDesc.Size = New System.Drawing.Size(80, 15)
        Me.LabelCurrentWeekOfYearDesc.TabIndex = 104
        Me.LabelCurrentWeekOfYearDesc.Text = "Week of Year:"
        '
        'LabelCurrentWeeksLeftDesc
        '
        Me.LabelCurrentWeeksLeftDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentWeeksLeftDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCurrentWeeksLeftDesc.Location = New System.Drawing.Point(392, 264)
        Me.LabelCurrentWeeksLeftDesc.Name = "LabelCurrentWeeksLeftDesc"
        Me.LabelCurrentWeeksLeftDesc.Size = New System.Drawing.Size(80, 15)
        Me.LabelCurrentWeeksLeftDesc.TabIndex = 103
        Me.LabelCurrentWeeksLeftDesc.Text = "Weeks Left:"
        '
        'LabelSelectedDate
        '
        Me.LabelSelectedDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectedDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSelectedDate.Location = New System.Drawing.Point(392, 314)
        Me.LabelSelectedDate.Name = "LabelSelectedDate"
        Me.LabelSelectedDate.Size = New System.Drawing.Size(108, 15)
        Me.LabelSelectedDate.TabIndex = 102
        '
        'LabelSelectedDayOfYear
        '
        Me.LabelSelectedDayOfYear.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectedDayOfYear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSelectedDayOfYear.Location = New System.Drawing.Point(360, 334)
        Me.LabelSelectedDayOfYear.Name = "LabelSelectedDayOfYear"
        Me.LabelSelectedDayOfYear.Size = New System.Drawing.Size(28, 15)
        Me.LabelSelectedDayOfYear.TabIndex = 101
        Me.LabelSelectedDayOfYear.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelSelectedDaysLeft
        '
        Me.LabelSelectedDaysLeft.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectedDaysLeft.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSelectedDaysLeft.Location = New System.Drawing.Point(360, 354)
        Me.LabelSelectedDaysLeft.Name = "LabelSelectedDaysLeft"
        Me.LabelSelectedDaysLeft.Size = New System.Drawing.Size(28, 15)
        Me.LabelSelectedDaysLeft.TabIndex = 100
        Me.LabelSelectedDaysLeft.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelOffsetFromToday
        '
        Me.LabelOffsetFromToday.BackColor = System.Drawing.Color.Transparent
        Me.LabelOffsetFromToday.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelOffsetFromToday.Location = New System.Drawing.Point(392, 374)
        Me.LabelOffsetFromToday.Name = "LabelOffsetFromToday"
        Me.LabelOffsetFromToday.Size = New System.Drawing.Size(108, 15)
        Me.LabelOffsetFromToday.TabIndex = 99
        '
        'labelSelectedHoliday
        '
        Me.labelSelectedHoliday.BackColor = System.Drawing.Color.Transparent
        Me.labelSelectedHoliday.ForeColor = System.Drawing.Color.DarkGreen
        Me.labelSelectedHoliday.Location = New System.Drawing.Point(280, 394)
        Me.labelSelectedHoliday.Name = "labelSelectedHoliday"
        Me.labelSelectedHoliday.Size = New System.Drawing.Size(220, 15)
        Me.labelSelectedHoliday.TabIndex = 98
        '
        'LabelSelectedDayOfYearDesc
        '
        Me.LabelSelectedDayOfYearDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectedDayOfYearDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSelectedDayOfYearDesc.Location = New System.Drawing.Point(280, 334)
        Me.LabelSelectedDayOfYearDesc.Name = "LabelSelectedDayOfYearDesc"
        Me.LabelSelectedDayOfYearDesc.Size = New System.Drawing.Size(76, 15)
        Me.LabelSelectedDayOfYearDesc.TabIndex = 96
        Me.LabelSelectedDayOfYearDesc.Text = "Day of Year:"
        '
        'LabelSelectedDaysLeftDesc
        '
        Me.LabelSelectedDaysLeftDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectedDaysLeftDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSelectedDaysLeftDesc.Location = New System.Drawing.Point(280, 354)
        Me.LabelSelectedDaysLeftDesc.Name = "LabelSelectedDaysLeftDesc"
        Me.LabelSelectedDaysLeftDesc.Size = New System.Drawing.Size(76, 15)
        Me.LabelSelectedDaysLeftDesc.TabIndex = 95
        Me.LabelSelectedDaysLeftDesc.Text = "Days Left:"
        '
        'LabelOffsetFromTodayDesc
        '
        Me.LabelOffsetFromTodayDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelOffsetFromTodayDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelOffsetFromTodayDesc.Location = New System.Drawing.Point(280, 374)
        Me.LabelOffsetFromTodayDesc.Name = "LabelOffsetFromTodayDesc"
        Me.LabelOffsetFromTodayDesc.Size = New System.Drawing.Size(108, 15)
        Me.LabelOffsetFromTodayDesc.TabIndex = 94
        Me.LabelOffsetFromTodayDesc.Text = "Offset from Today:"
        '
        'LabelSelectedDateDesc
        '
        Me.LabelSelectedDateDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectedDateDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSelectedDateDesc.Location = New System.Drawing.Point(280, 314)
        Me.LabelSelectedDateDesc.Name = "LabelSelectedDateDesc"
        Me.LabelSelectedDateDesc.Size = New System.Drawing.Size(108, 15)
        Me.LabelSelectedDateDesc.TabIndex = 93
        Me.LabelSelectedDateDesc.Text = "Selected Date:"
        '
        'LabelTCurrentDateDesc
        '
        Me.LabelTCurrentDateDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelTCurrentDateDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelTCurrentDateDesc.Location = New System.Drawing.Point(280, 224)
        Me.LabelTCurrentDateDesc.Name = "LabelTCurrentDateDesc"
        Me.LabelTCurrentDateDesc.Size = New System.Drawing.Size(108, 15)
        Me.LabelTCurrentDateDesc.TabIndex = 92
        Me.LabelTCurrentDateDesc.Text = "Today:"
        '
        'LabelCurrentDayOfYear
        '
        Me.LabelCurrentDayOfYear.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentDayOfYear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCurrentDayOfYear.Location = New System.Drawing.Point(360, 244)
        Me.LabelCurrentDayOfYear.Name = "LabelCurrentDayOfYear"
        Me.LabelCurrentDayOfYear.Size = New System.Drawing.Size(28, 15)
        Me.LabelCurrentDayOfYear.TabIndex = 91
        Me.LabelCurrentDayOfYear.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCurrentDaysLeft
        '
        Me.LabelCurrentDaysLeft.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentDaysLeft.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCurrentDaysLeft.Location = New System.Drawing.Point(360, 264)
        Me.LabelCurrentDaysLeft.Name = "LabelCurrentDaysLeft"
        Me.LabelCurrentDaysLeft.Size = New System.Drawing.Size(28, 15)
        Me.LabelCurrentDaysLeft.TabIndex = 90
        Me.LabelCurrentDaysLeft.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCurrentHoliday
        '
        Me.LabelCurrentHoliday.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentHoliday.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelCurrentHoliday.Location = New System.Drawing.Point(280, 284)
        Me.LabelCurrentHoliday.Name = "LabelCurrentHoliday"
        Me.LabelCurrentHoliday.Size = New System.Drawing.Size(220, 15)
        Me.LabelCurrentHoliday.TabIndex = 89
        '
        'LabelCurrentDayOfYearDesc
        '
        Me.LabelCurrentDayOfYearDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentDayOfYearDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCurrentDayOfYearDesc.Location = New System.Drawing.Point(280, 244)
        Me.LabelCurrentDayOfYearDesc.Name = "LabelCurrentDayOfYearDesc"
        Me.LabelCurrentDayOfYearDesc.Size = New System.Drawing.Size(76, 15)
        Me.LabelCurrentDayOfYearDesc.TabIndex = 87
        Me.LabelCurrentDayOfYearDesc.Text = "Day of Year:"
        '
        'LabelCurrentDaysLeftDesc
        '
        Me.LabelCurrentDaysLeftDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentDaysLeftDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCurrentDaysLeftDesc.Location = New System.Drawing.Point(280, 264)
        Me.LabelCurrentDaysLeftDesc.Name = "LabelCurrentDaysLeftDesc"
        Me.LabelCurrentDaysLeftDesc.Size = New System.Drawing.Size(76, 15)
        Me.LabelCurrentDaysLeftDesc.TabIndex = 86
        Me.LabelCurrentDaysLeftDesc.Text = "Days Left:"
        '
        'LabelCurrentDate
        '
        Me.LabelCurrentDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurrentDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCurrentDate.Location = New System.Drawing.Point(392, 224)
        Me.LabelCurrentDate.Name = "LabelCurrentDate"
        Me.LabelCurrentDate.Size = New System.Drawing.Size(108, 15)
        Me.LabelCurrentDate.TabIndex = 85
        '
        'DateAndTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SystemInformation.My.Resources.Resources.Background_Off_White
        Me.Controls.Add(Me.LabelSelectedWeekOfYear)
        Me.Controls.Add(Me.LabelSelectedWeeksLeft)
        Me.Controls.Add(Me.LabelSelectedWeekOfYearDesc)
        Me.Controls.Add(Me.LabelSelectedWeeksLeftDesc)
        Me.Controls.Add(Me.LabelCurrentWeekOfYear)
        Me.Controls.Add(Me.LabelCurrentWeeksLeft)
        Me.Controls.Add(Me.LabelCurrentWeekOfYearDesc)
        Me.Controls.Add(Me.LabelCurrentWeeksLeftDesc)
        Me.Controls.Add(Me.LabelSelectedDate)
        Me.Controls.Add(Me.LabelSelectedDayOfYear)
        Me.Controls.Add(Me.LabelSelectedDaysLeft)
        Me.Controls.Add(Me.LabelOffsetFromToday)
        Me.Controls.Add(Me.labelSelectedHoliday)
        Me.Controls.Add(Me.LabelSelectedDayOfYearDesc)
        Me.Controls.Add(Me.LabelSelectedDaysLeftDesc)
        Me.Controls.Add(Me.LabelOffsetFromTodayDesc)
        Me.Controls.Add(Me.LabelSelectedDateDesc)
        Me.Controls.Add(Me.LabelTCurrentDateDesc)
        Me.Controls.Add(Me.LabelCurrentDayOfYear)
        Me.Controls.Add(Me.LabelCurrentDaysLeft)
        Me.Controls.Add(Me.LabelCurrentHoliday)
        Me.Controls.Add(Me.LabelCurrentDayOfYearDesc)
        Me.Controls.Add(Me.LabelCurrentDaysLeftDesc)
        Me.Controls.Add(Me.LabelCurrentDate)
        Me.Controls.Add(Me.MonthCalendarDateTime)
        Me.Controls.Add(Me.LabelDaylightEndDesc)
        Me.Controls.Add(Me.LabelDaylightStartDesc)
        Me.Controls.Add(Me.LabelOffset)
        Me.Controls.Add(Me.LabelDaylightEnd)
        Me.Controls.Add(Me.LabelDaylightStart)
        Me.Controls.Add(Me.LabelSeparaterBottom)
        Me.Controls.Add(Me.LabelLocal)
        Me.Controls.Add(Me.LabelUniversalDateTime)
        Me.Controls.Add(Me.LabelUniversal)
        Me.Controls.Add(Me.LabelLocalDateTime)
        Me.Controls.Add(Me.LabelOffsetFromUTC)
        Me.Controls.Add(Me.LabelTimeZone)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Name = "DateAndTime"
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelLocalDateTime As System.Windows.Forms.Label
    Private WithEvents LabelOffsetFromUTC As System.Windows.Forms.Label
    Private WithEvents LabelTimeZone As System.Windows.Forms.Label
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents LabelUniversal As System.Windows.Forms.Label
    Private WithEvents LabelUniversalDateTime As System.Windows.Forms.Label
    Private WithEvents LabelLocal As System.Windows.Forms.Label
    Private WithEvents LabelDaylightEnd As System.Windows.Forms.Label
    Private WithEvents LabelDaylightStart As System.Windows.Forms.Label
    Private WithEvents LabelSeparaterBottom As System.Windows.Forms.Label
    Private WithEvents TimerDateTime As System.Windows.Forms.Timer
    Private WithEvents LabelOffset As System.Windows.Forms.Label
    Private WithEvents LabelDaylightStartDesc As System.Windows.Forms.Label
    Private WithEvents LabelDaylightEndDesc As System.Windows.Forms.Label
    Private WithEvents MonthCalendarDateTime As System.Windows.Forms.MonthCalendar
    Private WithEvents LabelSelectedWeekOfYear As System.Windows.Forms.Label
    Private WithEvents LabelSelectedWeeksLeft As System.Windows.Forms.Label
    Private WithEvents LabelSelectedWeekOfYearDesc As System.Windows.Forms.Label
    Private WithEvents LabelSelectedWeeksLeftDesc As System.Windows.Forms.Label
    Private WithEvents LabelCurrentWeekOfYear As System.Windows.Forms.Label
    Private WithEvents LabelCurrentWeeksLeft As System.Windows.Forms.Label
    Private WithEvents LabelCurrentWeekOfYearDesc As System.Windows.Forms.Label
    Private WithEvents LabelCurrentWeeksLeftDesc As System.Windows.Forms.Label
    Private WithEvents LabelSelectedDate As System.Windows.Forms.Label
    Private WithEvents LabelSelectedDayOfYear As System.Windows.Forms.Label
    Private WithEvents LabelSelectedDaysLeft As System.Windows.Forms.Label
    Private WithEvents LabelOffsetFromToday As System.Windows.Forms.Label
    Private WithEvents labelSelectedHoliday As System.Windows.Forms.Label
    Private WithEvents LabelSelectedDayOfYearDesc As System.Windows.Forms.Label
    Private WithEvents LabelSelectedDaysLeftDesc As System.Windows.Forms.Label
    Private WithEvents LabelOffsetFromTodayDesc As System.Windows.Forms.Label
    Private WithEvents LabelSelectedDateDesc As System.Windows.Forms.Label
    Private WithEvents LabelTCurrentDateDesc As System.Windows.Forms.Label
    Private WithEvents LabelCurrentDayOfYear As System.Windows.Forms.Label
    Private WithEvents LabelCurrentDaysLeft As System.Windows.Forms.Label
    Private WithEvents LabelCurrentHoliday As System.Windows.Forms.Label
    Private WithEvents LabelCurrentDayOfYearDesc As System.Windows.Forms.Label
    Private WithEvents LabelCurrentDaysLeftDesc As System.Windows.Forms.Label
    Private WithEvents LabelCurrentDate As System.Windows.Forms.Label

End Class
