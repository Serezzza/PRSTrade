Module PRSPerem
#Region "<Переменные>"
#Region "<Система>"
    Public PRS_entered As String = "N\A"
    Public PRS_shopname As String = "N\A"
    Public PRS_connection As String = PRS_GetConnectionState(PRS_Connected)
    Public PRS_dataconnection As String = "Активно"

    Public PRS_terminal_count As Integer = 1
    Public PRS_active_terminal_count As Integer = 1

    Public PRS_Theme As PRSStyles = PRSStyles.Aero

    Public PRS_isEntered As Boolean = False

    Public Enum PRSStyles
        Aero
        MsOfficeBlue
        MsOfficeSilver
        TradeLight
        TradeDark
    End Enum
#End Region
#Region "<Константы>"
    Public Countries() As String = (New String() {"United States", "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua & Barbuda", "Argentina", "Armenia", "Aruba (neth.)", "Australia", "Austria", "Azerbaijan", "Azores (port.)", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia And Herzegovina", "Botswana", "Brazil", "British Virgin Islands", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Fiji", "Finland", "Fmr Yug Rep Macedonia", "France", "French Guiana", "French Polynesia", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea Bissau", "Guyana", "Haiti", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Iraq-Saudi Arabia Neutral Zone", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea Dem.People's Rep.", "Korea, Republic Of", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya Arab Jamahiriy", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mexico", "Micronesia, Fed Stat", "Moldova, Republic Of", "Monaco", "Mongolia", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau Islands", "Panama", "Panama Canal Zone", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Lucia", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "St.Kitts & Nevis", "St.Vinct & Grenadine", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Rep.", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks And Caicos Islands", "Tuvalu", "U.S. Virgin Islands", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City (Holy See)", "Venezuela", "Vietnam", "Western Sahara", "Western Samoa", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe"})
    Public cam_path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Visual Studio 2012\Projects\PRS Trade v.1.0\PRS Trade v.1.0\CamShots\"
    Public _EnterOperations As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Visual Studio 2012\Projects\PRS Trade v.1.0\EnterOperations.txt"
    Public _AllOperations As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Visual Studio 2012\Projects\PRS Trade v.1.0\AllOperations.txt"
    Public _ShopName As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Visual Studio 2012\Projects\PRS Trade v.1.0\ShopName.txt"
    Public _SkladOperations As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Visual Studio 2012\Projects\PRS Trade v.1.0\SkladOperations.txt"
    Public _PersonalOperations As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Visual Studio 2012\Projects\PRS Trade v.1.0\PersonalOperations.txt"
    Public _PostavshikiOperations As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Visual Studio 2012\Projects\PRS Trade v.1.0\PostavshikiOperations.txt"
#End Region
#End Region
End Module
