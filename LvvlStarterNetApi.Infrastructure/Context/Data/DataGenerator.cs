using LvvlStarterNetApi.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Infrastructure.Context.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CliDbExampleContext(
                serviceProvider.GetRequiredService<DbContextOptions<CliDbExampleContext>>()))
            {
                // Look for any board games.
                //if (context..BoardGames.Any())
                //{
                //    return;   // Data was already seeded
                //}

                #region Users 
                context.Users.AddRange(
                    new User
                    {
                        UserId = 1,
                        FirstName = "Ken",
                        LastName = "Sánchez",
                        EmailAddress = "ken0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 2,
                        FirstName = "Terri",
                        LastName = "Duffy",
                        EmailAddress = "terri0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 3,
                        FirstName = "Roberto",
                        LastName = "Tamburello",
                        EmailAddress = "roberto0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 4,
                        FirstName = "Rob",
                        LastName = "Walters",
                        EmailAddress = "rob0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 5,
                        FirstName = "Gail",
                        LastName = "Erickson",
                        EmailAddress = "gail0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 6,
                        FirstName = "Jossef",
                        LastName = "Goldberg",
                        EmailAddress = "jossef0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 7,
                        FirstName = "Dylan",
                        LastName = "Miller",
                        EmailAddress = "dylan0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 8,
                        FirstName = "Diane",
                        LastName = "Margheim",
                        EmailAddress = "diane1@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 9,
                        FirstName = "Gigi",
                        LastName = "Matthew",
                        EmailAddress = "gigi0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 10,
                        FirstName = "Michael",
                        LastName = "Raheem",
                        EmailAddress = "michael6@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 11,
                        FirstName = "Ovidiu",
                        LastName = "Cracium",
                        EmailAddress = "ovidiu0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 12,
                        FirstName = "Thierry",
                        LastName = "DHers",
                        EmailAddress = "thierry0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 13,
                        FirstName = "Janice",
                        LastName = "Galvin",
                        EmailAddress = "janice0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 14,
                        FirstName = "Michael",
                        LastName = "Sullivan",
                        EmailAddress = "michael8@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 15,
                        FirstName = "Sharon",
                        LastName = "Salavaria",
                        EmailAddress = "sharon0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 16,
                        FirstName = "David",
                        LastName = "Bradley",
                        EmailAddress = "david0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 17,
                        FirstName = "Kevin",
                        LastName = "Brown",
                        EmailAddress = "kevin0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 18,
                        FirstName = "John",
                        LastName = "Wood",
                        EmailAddress = "john5@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 19,
                        FirstName = "Mary",
                        LastName = "Dempsey",
                        EmailAddress = "mary2@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 20,
                        FirstName = "Wanida",
                        LastName = "Benshoof",
                        EmailAddress = "wanida0@adventure-works.com"
                    }
                    );
                #endregion

                #region AddressTypes

                context.AddressTypes.AddRange(
                    new AddressType
                    {
                        AddressTypeId = 1,
                        Name = "Archive"
                    },

                    new AddressType
                    {
                        AddressTypeId = 2,
                        Name = "Billing"
                    },
                    new AddressType
                    {
                        AddressTypeId = 3,
                        Name = "Home"
                    },
                    new AddressType
                    {
                        AddressTypeId = 4,
                        Name = "Main Office"
                    },
                    new AddressType
                    {
                        AddressTypeId = 5,
                        Name = "Primary"
                    },
                    new AddressType
                    {
                        AddressTypeId = 6,
                        Name = "Shipping"
                    }
                  );

                #endregion

                #region CountryRegions

                context.CountryRegions.AddRange(
                    new CountryRegion { CountryRegionCode = "AD", Name = "Andorra" },
                    new CountryRegion { CountryRegionCode = "AE", Name = "United Arab Emirates" },
                    new CountryRegion { CountryRegionCode = "AF", Name = "Afghanistan" },
                    new CountryRegion { CountryRegionCode = "AG", Name = "Antigua and Barbuda" },
                    new CountryRegion { CountryRegionCode = "AI", Name = "Anguilla" },
                    new CountryRegion { CountryRegionCode = "AL", Name = "Albania" },
                    new CountryRegion { CountryRegionCode = "AM", Name = "Armenia" },
                    new CountryRegion { CountryRegionCode = "AN", Name = "Netherlands Antilles" },
                    new CountryRegion { CountryRegionCode = "AO", Name = "Angola" },
                    new CountryRegion { CountryRegionCode = "AQ", Name = "Antarctica" },
                    new CountryRegion { CountryRegionCode = "AR", Name = "Argentina" },
                    new CountryRegion { CountryRegionCode = "AS", Name = "American Samoa" },
                    new CountryRegion { CountryRegionCode = "AT", Name = "Austria" },
                    new CountryRegion { CountryRegionCode = "AU", Name = "Australia" },
                    new CountryRegion { CountryRegionCode = "AW", Name = "Aruba" },
                    new CountryRegion { CountryRegionCode = "AZ", Name = "Azerbaijan" },
                    new CountryRegion { CountryRegionCode = "BA", Name = "Bosnia and Herzegovina" },
                    new CountryRegion { CountryRegionCode = "BB", Name = "Barbados" },
                    new CountryRegion { CountryRegionCode = "BD", Name = "Bangladesh" },
                    new CountryRegion { CountryRegionCode = "BE", Name = "Belgium" },
                    new CountryRegion { CountryRegionCode = "BF", Name = "Burkina Faso" },
                    new CountryRegion { CountryRegionCode = "BG", Name = "Bulgaria" },
                    new CountryRegion { CountryRegionCode = "BH", Name = "Bahrain" },
                    new CountryRegion { CountryRegionCode = "BI", Name = "Burundi" },
                    new CountryRegion { CountryRegionCode = "BJ", Name = "Benin" },
                    new CountryRegion { CountryRegionCode = "BM", Name = "Bermuda" },
                    new CountryRegion { CountryRegionCode = "BN", Name = "Brunei" },
                    new CountryRegion { CountryRegionCode = "BO", Name = "Bolivia" },
                    new CountryRegion { CountryRegionCode = "BR", Name = "Brazil" },
                    new CountryRegion { CountryRegionCode = "BS", Name = "Bahamas, The" },
                    new CountryRegion { CountryRegionCode = "BT", Name = "Bhutan" },
                    new CountryRegion { CountryRegionCode = "BV", Name = "Bouvet Island" },
                    new CountryRegion { CountryRegionCode = "BW", Name = "Botswana" },
                    new CountryRegion { CountryRegionCode = "BY", Name = "Belarus" },
                    new CountryRegion { CountryRegionCode = "BZ", Name = "Belize" },
                    new CountryRegion { CountryRegionCode = "CA", Name = "Canada" },
                    new CountryRegion { CountryRegionCode = "CC", Name = "Cocos (Keeling) Islands" },
                    new CountryRegion { CountryRegionCode = "CD", Name = "Congo (DRC)" },
                    new CountryRegion { CountryRegionCode = "CF", Name = "Central African Republic" },
                    new CountryRegion { CountryRegionCode = "CG", Name = "Congo" },
                    new CountryRegion { CountryRegionCode = "CH", Name = "Switzerland" },
                    new CountryRegion { CountryRegionCode = "CI", Name = "Côte d'Ivoire" },
                    new CountryRegion { CountryRegionCode = "CK", Name = "Cook Islands" },
                    new CountryRegion { CountryRegionCode = "CL", Name = "Chile" },
                    new CountryRegion { CountryRegionCode = "CM", Name = "Cameroon" },
                    new CountryRegion { CountryRegionCode = "CN", Name = "China" },
                    new CountryRegion { CountryRegionCode = "CO", Name = "Colombia" },
                    new CountryRegion { CountryRegionCode = "CR", Name = "Costa Rica" },
                    new CountryRegion { CountryRegionCode = "CS", Name = "Serbia and Montenegro" },
                    new CountryRegion { CountryRegionCode = "CU", Name = "Cuba" },
                    new CountryRegion { CountryRegionCode = "CV", Name = "Cape Verde" },
                    new CountryRegion { CountryRegionCode = "CX", Name = "Christmas Island" },
                    new CountryRegion { CountryRegionCode = "CY", Name = "Cyprus" },
                    new CountryRegion { CountryRegionCode = "CZ", Name = "Czech Republic" },
                    new CountryRegion { CountryRegionCode = "DE", Name = "Germany" },
                    new CountryRegion { CountryRegionCode = "DJ", Name = "Djibouti" },
                    new CountryRegion { CountryRegionCode = "DK", Name = "Denmark" },
                    new CountryRegion { CountryRegionCode = "DM", Name = "Dominica" },
                    new CountryRegion { CountryRegionCode = "DO", Name = "Dominican Republic" },
                    new CountryRegion { CountryRegionCode = "DZ", Name = "Algeria" },
                    new CountryRegion { CountryRegionCode = "EC", Name = "Ecuador" },
                    new CountryRegion { CountryRegionCode = "EE", Name = "Estonia" },
                    new CountryRegion { CountryRegionCode = "EG", Name = "Egypt" },
                    new CountryRegion { CountryRegionCode = "ER", Name = "Eritrea" },
                    new CountryRegion { CountryRegionCode = "ES", Name = "Spain" },
                    new CountryRegion { CountryRegionCode = "ET", Name = "Ethiopia" },
                    new CountryRegion { CountryRegionCode = "FI", Name = "Finland" },
                    new CountryRegion { CountryRegionCode = "FJ", Name = "Fiji Islands" },
                    new CountryRegion { CountryRegionCode = "FK", Name = "Falkland Islands (Islas Malvinas)" },
                    new CountryRegion { CountryRegionCode = "FM", Name = "Micronesia" },
                    new CountryRegion { CountryRegionCode = "FO", Name = "Faroe Islands" },
                    new CountryRegion { CountryRegionCode = "FR", Name = "France" },
                    new CountryRegion { CountryRegionCode = "GA", Name = "Gabon" },
                    new CountryRegion { CountryRegionCode = "GB", Name = "United Kingdom" },
                    new CountryRegion { CountryRegionCode = "GD", Name = "Grenada" },
                    new CountryRegion { CountryRegionCode = "GE", Name = "Georgia" },
                    new CountryRegion { CountryRegionCode = "GF", Name = "French Guiana" },
                    new CountryRegion { CountryRegionCode = "GH", Name = "Ghana" },
                    new CountryRegion { CountryRegionCode = "GI", Name = "Gibraltar" },
                    new CountryRegion { CountryRegionCode = "GL", Name = "Greenland" },
                    new CountryRegion { CountryRegionCode = "GM", Name = "Gambia, The" },
                    new CountryRegion { CountryRegionCode = "GN", Name = "Guinea" },
                    new CountryRegion { CountryRegionCode = "GP", Name = "Guadeloupe" },
                    new CountryRegion { CountryRegionCode = "GQ", Name = "Equatorial Guinea" },
                    new CountryRegion { CountryRegionCode = "GR", Name = "Greece" },
                    new CountryRegion { CountryRegionCode = "GS", Name = "South Georgia and the South Sandwich Islands" },
                    new CountryRegion { CountryRegionCode = "GT", Name = "Guatemala" },
                    new CountryRegion { CountryRegionCode = "GU", Name = "Guam" },
                    new CountryRegion { CountryRegionCode = "GW", Name = "Guinea-Bissau" },
                    new CountryRegion { CountryRegionCode = "GY", Name = "Guyana" },
                    new CountryRegion { CountryRegionCode = "HK", Name = "Hong Kong SAR" },
                    new CountryRegion { CountryRegionCode = "HM", Name = "Heard Island and McDonald Islands" },
                    new CountryRegion { CountryRegionCode = "HN", Name = "Honduras" },
                    new CountryRegion { CountryRegionCode = "HR", Name = "Croatia" },
                    new CountryRegion { CountryRegionCode = "HT", Name = "Haiti" },
                    new CountryRegion { CountryRegionCode = "HU", Name = "Hungary" },
                    new CountryRegion { CountryRegionCode = "ID", Name = "Indonesia" },
                    new CountryRegion { CountryRegionCode = "IE", Name = "Ireland" },
                    new CountryRegion { CountryRegionCode = "IL", Name = "Israel" },
                    new CountryRegion { CountryRegionCode = "IN", Name = "India" },
                    new CountryRegion { CountryRegionCode = "IO", Name = "British Indian Ocean Territory" },
                    new CountryRegion { CountryRegionCode = "IQ", Name = "Iraq" },
                    new CountryRegion { CountryRegionCode = "IR", Name = "Iran" },
                    new CountryRegion { CountryRegionCode = "IS", Name = "Iceland" },
                    new CountryRegion { CountryRegionCode = "IT", Name = "Italy" },
                    new CountryRegion { CountryRegionCode = "JM", Name = "Jamaica" },
                    new CountryRegion { CountryRegionCode = "JO", Name = "Jordan" },
                    new CountryRegion { CountryRegionCode = "JP", Name = "Japan" },
                    new CountryRegion { CountryRegionCode = "KE", Name = "Kenya" },
                    new CountryRegion { CountryRegionCode = "KG", Name = "Kyrgyzstan" },
                    new CountryRegion { CountryRegionCode = "KH", Name = "Cambodia" },
                    new CountryRegion { CountryRegionCode = "KI", Name = "Kiribati" },
                    new CountryRegion { CountryRegionCode = "KM", Name = "Comoros" },
                    new CountryRegion { CountryRegionCode = "KN", Name = "Saint Kitts and Nevis" },
                    new CountryRegion { CountryRegionCode = "KP", Name = "North Korea" },
                    new CountryRegion { CountryRegionCode = "KR", Name = "Korea" },
                    new CountryRegion { CountryRegionCode = "KW", Name = "Kuwait" },
                    new CountryRegion { CountryRegionCode = "KY", Name = "Cayman Islands" },
                    new CountryRegion { CountryRegionCode = "KZ", Name = "Kazakhstan" },
                    new CountryRegion { CountryRegionCode = "LA", Name = "Laos" },
                    new CountryRegion { CountryRegionCode = "LB", Name = "Lebanon" },
                    new CountryRegion { CountryRegionCode = "LC", Name = "Saint Lucia" },
                    new CountryRegion { CountryRegionCode = "LI", Name = "Liechtenstein" },
                    new CountryRegion { CountryRegionCode = "LK", Name = "Sri Lanka" },
                    new CountryRegion { CountryRegionCode = "LR", Name = "Liberia" },
                    new CountryRegion { CountryRegionCode = "LS", Name = "Lesotho" },
                    new CountryRegion { CountryRegionCode = "LT", Name = "Lithuania" },
                    new CountryRegion { CountryRegionCode = "LU", Name = "Luxembourg" },
                    new CountryRegion { CountryRegionCode = "LV", Name = "Latvia" },
                    new CountryRegion { CountryRegionCode = "LY", Name = "Libya" },
                    new CountryRegion { CountryRegionCode = "MA", Name = "Morocco" },
                    new CountryRegion { CountryRegionCode = "MC", Name = "Monaco" },
                    new CountryRegion { CountryRegionCode = "MD", Name = "Moldova" },
                    new CountryRegion { CountryRegionCode = "MG", Name = "Madagascar" },
                    new CountryRegion { CountryRegionCode = "MH", Name = "Marshall Islands" },
                    new CountryRegion { CountryRegionCode = "MK", Name = "Macedonia, Former Yugoslav Republic of" },
                    new CountryRegion { CountryRegionCode = "ML", Name = "Mali" },
                    new CountryRegion { CountryRegionCode = "MM", Name = "Myanmar" },
                    new CountryRegion { CountryRegionCode = "MN", Name = "Mongolia" },
                    new CountryRegion { CountryRegionCode = "MO", Name = "Macao SAR" },
                    new CountryRegion { CountryRegionCode = "MP", Name = "Northern Mariana Islands" },
                    new CountryRegion { CountryRegionCode = "MQ", Name = "Martinique" },
                    new CountryRegion { CountryRegionCode = "MR", Name = "Mauritania" },
                    new CountryRegion { CountryRegionCode = "MS", Name = "Montserrat" },
                    new CountryRegion { CountryRegionCode = "MT", Name = "Malta" },
                    new CountryRegion { CountryRegionCode = "MU", Name = "Mauritius" },
                    new CountryRegion { CountryRegionCode = "MV", Name = "Maldives" },
                    new CountryRegion { CountryRegionCode = "MW", Name = "Malawi" },
                    new CountryRegion { CountryRegionCode = "MX", Name = "Mexico" },
                    new CountryRegion { CountryRegionCode = "MY", Name = "Malaysia" },
                    new CountryRegion { CountryRegionCode = "MZ", Name = "Mozambique" },
                    new CountryRegion { CountryRegionCode = "NA", Name = "Namibia" },
                    new CountryRegion { CountryRegionCode = "NC", Name = "New Caledonia" },
                    new CountryRegion { CountryRegionCode = "NE", Name = "Niger" },
                    new CountryRegion { CountryRegionCode = "NF", Name = "Norfolk Island" },
                    new CountryRegion { CountryRegionCode = "NG", Name = "Nigeria" },
                    new CountryRegion { CountryRegionCode = "NI", Name = "Nicaragua" },
                    new CountryRegion { CountryRegionCode = "NL", Name = "Netherlands" },
                    new CountryRegion { CountryRegionCode = "NO", Name = "Norway" },
                    new CountryRegion { CountryRegionCode = "NP", Name = "Nepal" },
                    new CountryRegion { CountryRegionCode = "NR", Name = "Nauru" },
                    new CountryRegion { CountryRegionCode = "NU", Name = "Niue" },
                    new CountryRegion { CountryRegionCode = "NZ", Name = "New Zealand" },
                    new CountryRegion { CountryRegionCode = "OM", Name = "Oman" },
                    new CountryRegion { CountryRegionCode = "PA", Name = "Panama" },
                    new CountryRegion { CountryRegionCode = "PE", Name = "Peru" },
                    new CountryRegion { CountryRegionCode = "PF", Name = "French Polynesia" },
                    new CountryRegion { CountryRegionCode = "PG", Name = "Papua New Guinea" },
                    new CountryRegion { CountryRegionCode = "PH", Name = "Philippines" },
                    new CountryRegion { CountryRegionCode = "PK", Name = "Pakistan" },
                    new CountryRegion { CountryRegionCode = "PL", Name = "Poland" },
                    new CountryRegion { CountryRegionCode = "PM", Name = "Saint Pierre and Miquelon" },
                    new CountryRegion { CountryRegionCode = "PN", Name = "Pitcairn Islands" },
                    new CountryRegion { CountryRegionCode = "PR", Name = "Puerto Rico" },
                    new CountryRegion { CountryRegionCode = "PS", Name = "Palestinian Authority" },
                    new CountryRegion { CountryRegionCode = "PT", Name = "Portugal" },
                    new CountryRegion { CountryRegionCode = "PW", Name = "Palau" },
                    new CountryRegion { CountryRegionCode = "PY", Name = "Paraguay" },
                    new CountryRegion { CountryRegionCode = "QA", Name = "Qatar" },
                    new CountryRegion { CountryRegionCode = "RE", Name = "Réunion" },
                    new CountryRegion { CountryRegionCode = "RO", Name = "Romania" },
                    new CountryRegion { CountryRegionCode = "RU", Name = "Russia" },
                    new CountryRegion { CountryRegionCode = "RW", Name = "Rwanda" },
                    new CountryRegion { CountryRegionCode = "SA", Name = "Saudi Arabia" },
                    new CountryRegion { CountryRegionCode = "SB", Name = "Solomon Islands" },
                    new CountryRegion { CountryRegionCode = "SC", Name = "Seychelles" },
                    new CountryRegion { CountryRegionCode = "SD", Name = "Sudan" },
                    new CountryRegion { CountryRegionCode = "SE", Name = "Sweden" },
                    new CountryRegion { CountryRegionCode = "SG", Name = "Singapore" },
                    new CountryRegion { CountryRegionCode = "SH", Name = "Saint Helena" },
                    new CountryRegion { CountryRegionCode = "SI", Name = "Slovenia" },
                    new CountryRegion { CountryRegionCode = "SJ", Name = "Svalbard and Jan Mayen" },
                    new CountryRegion { CountryRegionCode = "SK", Name = "Slovakia" },
                    new CountryRegion { CountryRegionCode = "SL", Name = "Sierra Leone" },
                    new CountryRegion { CountryRegionCode = "SM", Name = "San Marino" },
                    new CountryRegion { CountryRegionCode = "SN", Name = "Senegal" },
                    new CountryRegion { CountryRegionCode = "SO", Name = "Somalia" },
                    new CountryRegion { CountryRegionCode = "SR", Name = "Suriname" },
                    new CountryRegion { CountryRegionCode = "ST", Name = "São Tomé and Príncipe" },
                    new CountryRegion { CountryRegionCode = "SV", Name = "El Salvador" },
                    new CountryRegion { CountryRegionCode = "SY", Name = "Syria" },
                    new CountryRegion { CountryRegionCode = "SZ", Name = "Swaziland" },
                    new CountryRegion { CountryRegionCode = "TC", Name = "Turks and Caicos Islands" },
                    new CountryRegion { CountryRegionCode = "TD", Name = "Chad" },
                    new CountryRegion { CountryRegionCode = "TF", Name = "French Southern and Antarctic Lands" },
                    new CountryRegion { CountryRegionCode = "TG", Name = "Togo" },
                    new CountryRegion { CountryRegionCode = "TH", Name = "Thailand" },
                    new CountryRegion { CountryRegionCode = "TJ", Name = "Tajikistan" },
                    new CountryRegion { CountryRegionCode = "TK", Name = "Tokelau" },
                    new CountryRegion { CountryRegionCode = "TL", Name = "Timor-Leste" },
                    new CountryRegion { CountryRegionCode = "TM", Name = "Turkmenistan" },
                    new CountryRegion { CountryRegionCode = "TN", Name = "Tunisia" },
                    new CountryRegion { CountryRegionCode = "TO", Name = "Tonga" },
                    new CountryRegion { CountryRegionCode = "TR", Name = "Turkey" },
                    new CountryRegion { CountryRegionCode = "TT", Name = "Trinidad and Tobago" },
                    new CountryRegion { CountryRegionCode = "TV", Name = "Tuvalu" },
                    new CountryRegion { CountryRegionCode = "TW", Name = "Taiwan" },
                    new CountryRegion { CountryRegionCode = "TZ", Name = "Tanzania" },
                    new CountryRegion { CountryRegionCode = "UA", Name = "Ukraine" },
                    new CountryRegion { CountryRegionCode = "UG", Name = "Uganda" },
                    new CountryRegion { CountryRegionCode = "UM", Name = "U.S. Minor Outlying Islands" },
                    new CountryRegion { CountryRegionCode = "US", Name = "United States" },
                    new CountryRegion { CountryRegionCode = "UY", Name = "Uruguay" },
                    new CountryRegion { CountryRegionCode = "UZ", Name = "Uzbekistan" },
                    new CountryRegion { CountryRegionCode = "VA", Name = "Vatican City" },
                    new CountryRegion { CountryRegionCode = "VC", Name = "Saint Vincent and the Grenadine" },
                    new CountryRegion { CountryRegionCode = "VE", Name = "Venezuela" },
                    new CountryRegion { CountryRegionCode = "VG", Name = "Virgin Islands, British" },
                    new CountryRegion { CountryRegionCode = "VI", Name = "Virgin Islands, U.S." },
                    new CountryRegion { CountryRegionCode = "VN", Name = "Vietnam" },
                    new CountryRegion { CountryRegionCode = "VU", Name = "Vanuatu" },
                    new CountryRegion { CountryRegionCode = "WF", Name = "Wallis and Futuna" },
                    new CountryRegion { CountryRegionCode = "WS", Name = "Samoa" },
                    new CountryRegion { CountryRegionCode = "YE", Name = "Yemen" },
                    new CountryRegion { CountryRegionCode = "YT", Name = "Mayotte" },
                    new CountryRegion { CountryRegionCode = "ZA", Name = "South Africa" },
                    new CountryRegion { CountryRegionCode = "ZM", Name = "Zambia" },
                    new CountryRegion { CountryRegionCode = "ZW", Name = "Zimbabwe" }
                    );

                #endregion

                #region StateProvinces

                context.StateProvinces.AddRange(
                    new StateProvince { StateProvinceId = 1, StateProvinceCode = "AB ", Name = "Alberta" },
                    new StateProvince { StateProvinceId = 2, StateProvinceCode = "AK ", Name = "Alaska" },
                    new StateProvince { StateProvinceId = 3, StateProvinceCode = "AL ", Name = "Alabama" },
                    new StateProvince { StateProvinceId = 4, StateProvinceCode = "AR ", Name = "Arkansas" },
                    new StateProvince { StateProvinceId = 5, StateProvinceCode = "AS ", Name = "American Samoa" },
                    new StateProvince { StateProvinceId = 6, StateProvinceCode = "AZ ", Name = "Arizona" },
                    new StateProvince { StateProvinceId = 7, StateProvinceCode = "BC ", Name = "British Columbia" },
                    new StateProvince { StateProvinceId = 8, StateProvinceCode = "BY ", Name = "Bayern" },
                    new StateProvince { StateProvinceId = 9, StateProvinceCode = "CA ", Name = "California" },
                    new StateProvince { StateProvinceId = 10, StateProvinceCode = "CO ", Name = "Colorado" },
                    new StateProvince { StateProvinceId = 11, StateProvinceCode = "CT ", Name = "Connecticut" },
                    new StateProvince { StateProvinceId = 12, StateProvinceCode = "DC ", Name = "District of Columbia" },
                    new StateProvince { StateProvinceId = 13, StateProvinceCode = "DE ", Name = "Delaware" },
                    new StateProvince { StateProvinceId = 14, StateProvinceCode = "ENG", Name = "England" },
                    new StateProvince { StateProvinceId = 15, StateProvinceCode = "FL ", Name = "Florida" },
                    new StateProvince { StateProvinceId = 16, StateProvinceCode = "FM ", Name = "Micronesia" },
                    new StateProvince { StateProvinceId = 17, StateProvinceCode = "GA ", Name = "Georgia" },
                    new StateProvince { StateProvinceId = 18, StateProvinceCode = "GU ", Name = "Guam" },
                    new StateProvince { StateProvinceId = 19, StateProvinceCode = "HE ", Name = "Hessen" },
                    new StateProvince { StateProvinceId = 20, StateProvinceCode = "HH ", Name = "Hamburg" },
                    new StateProvince { StateProvinceId = 21, StateProvinceCode = "HI ", Name = "Hawaii" },
                    new StateProvince { StateProvinceId = 22, StateProvinceCode = "IA ", Name = "Iowa" },
                    new StateProvince { StateProvinceId = 23, StateProvinceCode = "ID ", Name = "Idaho" },
                    new StateProvince { StateProvinceId = 24, StateProvinceCode = "IL ", Name = "Illinois" },
                    new StateProvince { StateProvinceId = 25, StateProvinceCode = "IN ", Name = "Indiana" },
                    new StateProvince { StateProvinceId = 26, StateProvinceCode = "KS ", Name = "Kansas" },
                    new StateProvince { StateProvinceId = 27, StateProvinceCode = "KY ", Name = "Kentucky" },
                    new StateProvince { StateProvinceId = 28, StateProvinceCode = "LA ", Name = "Louisiana" },
                    new StateProvince { StateProvinceId = 29, StateProvinceCode = "LB ", Name = "Labrador" },
                    new StateProvince { StateProvinceId = 30, StateProvinceCode = "MA ", Name = "Massachusetts" },
                    new StateProvince { StateProvinceId = 31, StateProvinceCode = "MB ", Name = "Manitoba" },
                    new StateProvince { StateProvinceId = 32, StateProvinceCode = "MD ", Name = "Maryland" },
                    new StateProvince { StateProvinceId = 33, StateProvinceCode = "ME ", Name = "Maine" },
                    new StateProvince { StateProvinceId = 34, StateProvinceCode = "MH ", Name = "Marshall Islands" },
                    new StateProvince { StateProvinceId = 35, StateProvinceCode = "MI ", Name = "Michigan" },
                    new StateProvince { StateProvinceId = 36, StateProvinceCode = "MN ", Name = "Minnesota" },
                    new StateProvince { StateProvinceId = 37, StateProvinceCode = "MO ", Name = "Missouri" },
                    new StateProvince { StateProvinceId = 38, StateProvinceCode = "MP ", Name = "Northern Mariana Islands" },
                    new StateProvince { StateProvinceId = 39, StateProvinceCode = "MS ", Name = "Mississippi" },
                    new StateProvince { StateProvinceId = 40, StateProvinceCode = "MT ", Name = "Montana" },
                    new StateProvince { StateProvinceId = 41, StateProvinceCode = "NB ", Name = "Brunswick" },
                    new StateProvince { StateProvinceId = 42, StateProvinceCode = "NC ", Name = "North Carolina" },
                    new StateProvince { StateProvinceId = 43, StateProvinceCode = "ND ", Name = "North Dakota" },
                    new StateProvince { StateProvinceId = 44, StateProvinceCode = "NE ", Name = "Nebraska" },
                    new StateProvince { StateProvinceId = 45, StateProvinceCode = "NF ", Name = "Newfoundland" },
                    new StateProvince { StateProvinceId = 46, StateProvinceCode = "NH ", Name = "New Hampshire" },
                    new StateProvince { StateProvinceId = 47, StateProvinceCode = "NJ ", Name = "New Jersey" },
                    new StateProvince { StateProvinceId = 48, StateProvinceCode = "NM ", Name = "New Mexico" },
                    new StateProvince { StateProvinceId = 49, StateProvinceCode = "NS ", Name = "Nova Scotia" },
                    new StateProvince { StateProvinceId = 50, StateProvinceCode = "NSW", Name = "New South Wales" },
                    new StateProvince { StateProvinceId = 51, StateProvinceCode = "NT ", Name = "Northwest Territories" },
                    new StateProvince { StateProvinceId = 52, StateProvinceCode = "NV ", Name = "Nevada" },
                    new StateProvince { StateProvinceId = 53, StateProvinceCode = "NW ", Name = "Nordrhein-Westfalen" },
                    new StateProvince { StateProvinceId = 54, StateProvinceCode = "NY ", Name = "New York" },
                    new StateProvince { StateProvinceId = 55, StateProvinceCode = "OH ", Name = "Ohio" },
                    new StateProvince { StateProvinceId = 56, StateProvinceCode = "OK ", Name = "Oklahoma" },
                    new StateProvince { StateProvinceId = 57, StateProvinceCode = "ON ", Name = "Ontario" },
                    new StateProvince { StateProvinceId = 58, StateProvinceCode = "OR ", Name = "Oregon" },
                    new StateProvince { StateProvinceId = 59, StateProvinceCode = "PA ", Name = "Pennsylvania" },
                    new StateProvince { StateProvinceId = 60, StateProvinceCode = "PE ", Name = "Prince Edward Island" },
                    new StateProvince { StateProvinceId = 61, StateProvinceCode = "PR ", Name = "Puerto Rico" },
                    new StateProvince { StateProvinceId = 62, StateProvinceCode = "PW ", Name = "Palau" },
                    new StateProvince { StateProvinceId = 63, StateProvinceCode = "QC ", Name = "Quebec" },
                    new StateProvince { StateProvinceId = 64, StateProvinceCode = "QLD", Name = "Queensland" },
                    new StateProvince { StateProvinceId = 65, StateProvinceCode = "RI ", Name = "Rhode Island" },
                    new StateProvince { StateProvinceId = 66, StateProvinceCode = "SA ", Name = "South Australia" },
                    new StateProvince { StateProvinceId = 67, StateProvinceCode = "SC ", Name = "South Carolina" },
                    new StateProvince { StateProvinceId = 68, StateProvinceCode = "SD ", Name = "South Dakota" },
                    new StateProvince { StateProvinceId = 69, StateProvinceCode = "SK ", Name = "Saskatchewan" },
                    new StateProvince { StateProvinceId = 70, StateProvinceCode = "SL ", Name = "Saarland" },
                    new StateProvince { StateProvinceId = 71, StateProvinceCode = "TAS", Name = "Tasmania" },
                    new StateProvince { StateProvinceId = 72, StateProvinceCode = "TN ", Name = "Tennessee" },
                    new StateProvince { StateProvinceId = 73, StateProvinceCode = "TX ", Name = "Texas" },
                    new StateProvince { StateProvinceId = 74, StateProvinceCode = "UT ", Name = "Utah" },
                    new StateProvince { StateProvinceId = 75, StateProvinceCode = "VA ", Name = "Virginia" },
                    new StateProvince { StateProvinceId = 76, StateProvinceCode = "VI ", Name = "Virgin Islands" },
                    new StateProvince { StateProvinceId = 77, StateProvinceCode = "VIC", Name = "Victoria" },
                    new StateProvince { StateProvinceId = 78, StateProvinceCode = "VT ", Name = "Vermont" },
                    new StateProvince { StateProvinceId = 79, StateProvinceCode = "WA ", Name = "Washington" },
                    new StateProvince { StateProvinceId = 80, StateProvinceCode = "WI ", Name = "Wisconsin" },
                    new StateProvince { StateProvinceId = 81, StateProvinceCode = "WV ", Name = "West Virginia" },
                    new StateProvince { StateProvinceId = 82, StateProvinceCode = "WY ", Name = "Wyoming" },
                    new StateProvince { StateProvinceId = 83, StateProvinceCode = "YT ", Name = "Yukon Territory" },
                    new StateProvince { StateProvinceId = 84, StateProvinceCode = "FR ", Name = "France" },
                    new StateProvince { StateProvinceId = 85, StateProvinceCode = "BB ", Name = "Brandenburg" },
                    new StateProvince { StateProvinceId = 86, StateProvinceCode = "SN ", Name = "Saxony" },
                    new StateProvince { StateProvinceId = 87, StateProvinceCode = "01 ", Name = "Ain" },
                    new StateProvince { StateProvinceId = 88, StateProvinceCode = "02 ", Name = "Aisne" },
                    new StateProvince { StateProvinceId = 89, StateProvinceCode = "03 ", Name = "Allier" },
                    new StateProvince { StateProvinceId = 90, StateProvinceCode = "04 ", Name = "Alpes-de-Haute Provence" },
                    new StateProvince { StateProvinceId = 91, StateProvinceCode = "05 ", Name = "Alpes (Haute)" },
                    new StateProvince { StateProvinceId = 92, StateProvinceCode = "06 ", Name = "Alpes-Maritimes" },
                    new StateProvince { StateProvinceId = 93, StateProvinceCode = "07 ", Name = "Ardèche" },
                    new StateProvince { StateProvinceId = 94, StateProvinceCode = "08 ", Name = "Ardennes" },
                    new StateProvince { StateProvinceId = 95, StateProvinceCode = "09 ", Name = "Ariège" },
                    new StateProvince { StateProvinceId = 96, StateProvinceCode = "10 ", Name = "Aube" },
                    new StateProvince { StateProvinceId = 97, StateProvinceCode = "11 ", Name = "Aude" },
                    new StateProvince { StateProvinceId = 98, StateProvinceCode = "12 ", Name = "Aveyron" },
                    new StateProvince { StateProvinceId = 99, StateProvinceCode = "13 ", Name = "Bouches du Rhône" },
                    new StateProvince { StateProvinceId = 100, StateProvinceCode = "14 ", Name = "Calvados" },
                    new StateProvince { StateProvinceId = 101, StateProvinceCode = "15 ", Name = "Cantal" },
                    new StateProvince { StateProvinceId = 102, StateProvinceCode = "16 ", Name = "Charente" },
                    new StateProvince { StateProvinceId = 103, StateProvinceCode = "17 ", Name = "Charente-Maritime" },
                    new StateProvince { StateProvinceId = 104, StateProvinceCode = "18 ", Name = "Cher" },
                    new StateProvince { StateProvinceId = 105, StateProvinceCode = "19 ", Name = "Corrèze" },
                    new StateProvince { StateProvinceId = 106, StateProvinceCode = "20 ", Name = "Corse" },
                    new StateProvince { StateProvinceId = 107, StateProvinceCode = "21 ", Name = "Côte dOr" },
                    new StateProvince { StateProvinceId = 108, StateProvinceCode = "22 ", Name = "Côtes-dArmor" },
                    new StateProvince { StateProvinceId = 109, StateProvinceCode = "23 ", Name = "Creuse" },
                    new StateProvince { StateProvinceId = 110, StateProvinceCode = "24 ", Name = "Dordogne" },
                    new StateProvince { StateProvinceId = 111, StateProvinceCode = "25 ", Name = "Toubs" },
                    new StateProvince { StateProvinceId = 112, StateProvinceCode = "26 ", Name = "Drôme" },
                    new StateProvince { StateProvinceId = 113, StateProvinceCode = "27 ", Name = "Eure" },
                    new StateProvince { StateProvinceId = 114, StateProvinceCode = "28 ", Name = "Eure et Loir" },
                    new StateProvince { StateProvinceId = 115, StateProvinceCode = "29 ", Name = "Finistère" },
                    new StateProvince { StateProvinceId = 116, StateProvinceCode = "30 ", Name = "Gard" },
                    new StateProvince { StateProvinceId = 117, StateProvinceCode = "31 ", Name = "Garonne (Haute)" },
                    new StateProvince { StateProvinceId = 118, StateProvinceCode = "32 ", Name = "Gers" },
                    new StateProvince { StateProvinceId = 119, StateProvinceCode = "33 ", Name = "Gironde" },
                    new StateProvince { StateProvinceId = 120, StateProvinceCode = "34 ", Name = "Hérault" },
                    new StateProvince { StateProvinceId = 121, StateProvinceCode = "35 ", Name = "Ille et Vilaine" },
                    new StateProvince { StateProvinceId = 122, StateProvinceCode = "36 ", Name = "Indre" },
                    new StateProvince { StateProvinceId = 123, StateProvinceCode = "37 ", Name = "Indre et Loire" },
                    new StateProvince { StateProvinceId = 124, StateProvinceCode = "38 ", Name = "Isère" },
                    new StateProvince { StateProvinceId = 125, StateProvinceCode = "39 ", Name = "Jura" },
                    new StateProvince { StateProvinceId = 126, StateProvinceCode = "40 ", Name = "Landes" },
                    new StateProvince { StateProvinceId = 127, StateProvinceCode = "41 ", Name = "Loir et Cher" },
                    new StateProvince { StateProvinceId = 128, StateProvinceCode = "42 ", Name = "Loire" },
                    new StateProvince { StateProvinceId = 129, StateProvinceCode = "43 ", Name = "Loire (Haute)" },
                    new StateProvince { StateProvinceId = 130, StateProvinceCode = "44 ", Name = "Loire Atlantique" },
                    new StateProvince { StateProvinceId = 131, StateProvinceCode = "45 ", Name = "Loiret" },
                    new StateProvince { StateProvinceId = 132, StateProvinceCode = "46 ", Name = "Lot" },
                    new StateProvince { StateProvinceId = 133, StateProvinceCode = "47 ", Name = "Lot et Garonne" },
                    new StateProvince { StateProvinceId = 134, StateProvinceCode = "48 ", Name = "Lozère" },
                    new StateProvince { StateProvinceId = 135, StateProvinceCode = "49 ", Name = "Maine et Loire" },
                    new StateProvince { StateProvinceId = 136, StateProvinceCode = "50 ", Name = "Manche" },
                    new StateProvince { StateProvinceId = 137, StateProvinceCode = "51 ", Name = "Marne" },
                    new StateProvince { StateProvinceId = 138, StateProvinceCode = "52 ", Name = "Marne (Haute)" },
                    new StateProvince { StateProvinceId = 139, StateProvinceCode = "53 ", Name = "Mayenne" },
                    new StateProvince { StateProvinceId = 140, StateProvinceCode = "54 ", Name = "Meurthe et Moselle" },
                    new StateProvince { StateProvinceId = 141, StateProvinceCode = "55 ", Name = "Meuse" },
                    new StateProvince { StateProvinceId = 142, StateProvinceCode = "56 ", Name = "Morbihan" },
                    new StateProvince { StateProvinceId = 143, StateProvinceCode = "57 ", Name = "Moselle" },
                    new StateProvince { StateProvinceId = 144, StateProvinceCode = "58 ", Name = "Nièvre" },
                    new StateProvince { StateProvinceId = 145, StateProvinceCode = "59 ", Name = "Nord" },
                    new StateProvince { StateProvinceId = 146, StateProvinceCode = "60 ", Name = "Oise" },
                    new StateProvince { StateProvinceId = 147, StateProvinceCode = "61 ", Name = "Orne" },
                    new StateProvince { StateProvinceId = 148, StateProvinceCode = "62 ", Name = "Pas de Calais" },
                    new StateProvince { StateProvinceId = 149, StateProvinceCode = "63 ", Name = "Puy de Dôme" },
                    new StateProvince { StateProvinceId = 150, StateProvinceCode = "64 ", Name = "Pyrénées Atlantiques" },
                    new StateProvince { StateProvinceId = 151, StateProvinceCode = "65 ", Name = "Pyrénées (Hautes)" },
                    new StateProvince { StateProvinceId = 152, StateProvinceCode = "66 ", Name = "Pyrénées Orientales" },
                    new StateProvince { StateProvinceId = 153, StateProvinceCode = "67 ", Name = "Rhin (Bas)" },
                    new StateProvince { StateProvinceId = 154, StateProvinceCode = "68 ", Name = "Rhin (Haut)" },
                    new StateProvince { StateProvinceId = 155, StateProvinceCode = "69 ", Name = "Rhône" },
                    new StateProvince { StateProvinceId = 156, StateProvinceCode = "70 ", Name = "Saône (Haute)" },
                    new StateProvince { StateProvinceId = 157, StateProvinceCode = "71 ", Name = "Saône et Loire" },
                    new StateProvince { StateProvinceId = 158, StateProvinceCode = "72 ", Name = "Sarthe" },
                    new StateProvince { StateProvinceId = 159, StateProvinceCode = "73 ", Name = "Savoie" },
                    new StateProvince { StateProvinceId = 160, StateProvinceCode = "74 ", Name = "Savoie Haute" },
                    new StateProvince { StateProvinceId = 161, StateProvinceCode = "75 ", Name = "Seine (Paris)" },
                    new StateProvince { StateProvinceId = 162, StateProvinceCode = "76 ", Name = "Seine Maritime" },
                    new StateProvince { StateProvinceId = 163, StateProvinceCode = "77 ", Name = "Seine et Marne" },
                    new StateProvince { StateProvinceId = 164, StateProvinceCode = "78 ", Name = "Yveline" },
                    new StateProvince { StateProvinceId = 165, StateProvinceCode = "79 ", Name = "Sèvres (Deux)" },
                    new StateProvince { StateProvinceId = 166, StateProvinceCode = "80 ", Name = "Somme" },
                    new StateProvince { StateProvinceId = 167, StateProvinceCode = "81 ", Name = "Tarne" },
                    new StateProvince { StateProvinceId = 168, StateProvinceCode = "82 ", Name = "Tarne et Garonne" },
                    new StateProvince { StateProvinceId = 169, StateProvinceCode = "83 ", Name = "Var" },
                    new StateProvince { StateProvinceId = 170, StateProvinceCode = "84 ", Name = "Vaucluse" },
                    new StateProvince { StateProvinceId = 171, StateProvinceCode = "85 ", Name = "La Vendée" },
                    new StateProvince { StateProvinceId = 172, StateProvinceCode = "86 ", Name = "Vienne" },
                    new StateProvince { StateProvinceId = 173, StateProvinceCode = "87 ", Name = "Vienne (Haute)" },
                    new StateProvince { StateProvinceId = 174, StateProvinceCode = "88 ", Name = "Vosges" },
                    new StateProvince { StateProvinceId = 175, StateProvinceCode = "89 ", Name = "Yonne" },
                    new StateProvince { StateProvinceId = 176, StateProvinceCode = "90 ", Name = "Belford (Territoire de)" },
                    new StateProvince { StateProvinceId = 177, StateProvinceCode = "91 ", Name = "Essonne" },
                    new StateProvince { StateProvinceId = 178, StateProvinceCode = "92 ", Name = "Hauts de Seine" },
                    new StateProvince { StateProvinceId = 179, StateProvinceCode = "93 ", Name = "Seine Saint Denis" },
                    new StateProvince { StateProvinceId = 180, StateProvinceCode = "94 ", Name = "Val de Marne" },
                    new StateProvince { StateProvinceId = 181, StateProvinceCode = "95 ", Name = "Val dOise" }
                    );

                #endregion

                #region Addresses

                context.Addresses.AddRange(
                    new Address { AddressId = 1, AddressLine1 = "4350 Minute Dr.", AddressLine2 = String.Empty, City = "Newport Hills", StateProvinceId = 79, PostalCode = "98006", CountryRegionCode = "US", AddressTypeId = 3, UserId = 1 },
                    new Address { AddressId = 2, AddressLine1 = "7559 Worth Ct.", AddressLine2 = String.Empty, City = "Renton", StateProvinceId = 79, PostalCode = "98055", CountryRegionCode = "US", AddressTypeId = 3, UserId = 2 },
                    new Address { AddressId = 3, AddressLine1 = "2137 Birchwood Dr", AddressLine2 = String.Empty, City = "Redmond", StateProvinceId = 79, PostalCode = "98052", CountryRegionCode = "US", AddressTypeId = 3, UserId = 3 },
                    new Address { AddressId = 4, AddressLine1 = "5678 Lakeview Blvd.", AddressLine2 = String.Empty, City = "Minneapolis", StateProvinceId = 36, PostalCode = "55402", CountryRegionCode = "US", AddressTypeId = 3, UserId = 4 },
                    new Address { AddressId = 5, AddressLine1 = "9435 Breck Court", AddressLine2 = String.Empty, City = "Bellevue", StateProvinceId = 79, PostalCode = "98004", CountryRegionCode = "US", AddressTypeId = 3, UserId = 5 },
                    new Address { AddressId = 6, AddressLine1 = "5670 Bel Air Dr.", AddressLine2 = String.Empty, City = "Renton", StateProvinceId = 79, PostalCode = "98055", CountryRegionCode = "US", AddressTypeId = 3, UserId = 6 },
                    new Address { AddressId = 7, AddressLine1 = "7048 Laurel", AddressLine2 = String.Empty, City = "Kenmore", StateProvinceId = 79, PostalCode = "98028", CountryRegionCode = "US", AddressTypeId = 3, UserId = 7 },
                    new Address { AddressId = 8, AddressLine1 = "475 Santa Maria", AddressLine2 = String.Empty, City = "Everett", StateProvinceId = 79, PostalCode = "98201", CountryRegionCode = "US", AddressTypeId = 3, UserId = 8 },
                    new Address { AddressId = 9, AddressLine1 = "7808 Brown St.", AddressLine2 = String.Empty, City = "Bellevue", StateProvinceId = 79, PostalCode = "98004", CountryRegionCode = "US", AddressTypeId = 3, UserId = 9 },
                    new Address { AddressId = 10, AddressLine1 = "1234 Seaside Way", AddressLine2 = String.Empty, City = "San Francisco", StateProvinceId = 9, PostalCode = "94109", CountryRegionCode = "US", AddressTypeId = 3, UserId = 10 },
                    new Address { AddressId = 11, AddressLine1 = "5458 Gladstone Drive", AddressLine2 = String.Empty, City = "Kenmore", StateProvinceId = 79, PostalCode = "98028", CountryRegionCode = "US", AddressTypeId = 3, UserId = 11 },
                    new Address { AddressId = 12, AddressLine1 = "1970 Napa Ct.", AddressLine2 = String.Empty, City = "Bothell", StateProvinceId = 79, PostalCode = "98011", CountryRegionCode = "US", AddressTypeId = 3, UserId = 12 },
                    new Address { AddressId = 13, AddressLine1 = "3397 Rancho View Drive", AddressLine2 = String.Empty, City = "Redmond", StateProvinceId = 79, PostalCode = "98052", CountryRegionCode = "US", AddressTypeId = 3, UserId = 13 },
                    new Address { AddressId = 14, AddressLine1 = "6510 Hacienda Drive", AddressLine2 = String.Empty, City = "Renton", StateProvinceId = 79, PostalCode = "98055", CountryRegionCode = "US", AddressTypeId = 3, UserId = 14 },
                    new Address { AddressId = 15, AddressLine1 = "7165 Brock Lane", AddressLine2 = String.Empty, City = "Renton", StateProvinceId = 79, PostalCode = "98055", CountryRegionCode = "US", AddressTypeId = 3, UserId = 15 },
                    new Address { AddressId = 16, AddressLine1 = "3768 Door Way", AddressLine2 = String.Empty, City = "Redmond", StateProvinceId = 79, PostalCode = "98052", CountryRegionCode = "US", AddressTypeId = 3, UserId = 16 },
                    new Address { AddressId = 17, AddressLine1 = "7883 Missing Canyon Court", AddressLine2 = String.Empty, City = "Everett", StateProvinceId = 79, PostalCode = "98201", CountryRegionCode = "US", AddressTypeId = 3, UserId = 17 },
                    new Address { AddressId = 18, AddressLine1 = "9906 Oak Grove Road", AddressLine2 = String.Empty, City = "Redmond", StateProvinceId = 79, PostalCode = "98052", CountryRegionCode = "US", AddressTypeId = 3, UserId = 18 },
                    new Address { AddressId = 19, AddressLine1 = "6307 Greenbelt Way", AddressLine2 = String.Empty, City = "Bellevue", StateProvinceId = 79, PostalCode = "98004", CountryRegionCode = "US", AddressTypeId = 3, UserId = 19 },
                    new Address { AddressId = 20, AddressLine1 = "6951 Harmony Way", AddressLine2 = String.Empty, City = "Sammamish", StateProvinceId = 79, PostalCode = "98074", CountryRegionCode = "US", AddressTypeId = 3, UserId = 20 }
                    );

                #endregion

                #region PhoneNumberTypes

                context.PhoneNumberTypes.AddRange(
                    new PhoneNumberType { PhoneNumberTypeId = 1, Name = "Cell" },
                    new PhoneNumberType { PhoneNumberTypeId = 2, Name = "Home" },
                    new PhoneNumberType { PhoneNumberTypeId = 3, Name = "Work" }
                    );

                #endregion

                context.Phones.AddRange(

                    new Phone { PhoneId = 1, PhoneNumber = "697-555-0142", PhoneNumberTypeId = 1, UserId = 1 },
                    new Phone
                    {
                        PhoneId = 2,
                        PhoneNumber = "819-555-0175",
                        PhoneNumberTypeId = 3,
                        UserId = 2
                    },
                    new Phone
                    {
                        PhoneId = 3,
                        PhoneNumber = "212-555-0187",
                        PhoneNumberTypeId = 1,
                        UserId = 3
                    },
                    new Phone
                    {
                        PhoneId = 4,
                        PhoneNumber = "612-555-0100",
                        PhoneNumberTypeId = 1,
                        UserId = 4
                    },
                    new Phone
                    {
                        PhoneId = 5,
                        PhoneNumber = "849-555-0139",
                        PhoneNumberTypeId = 1,
                        UserId = 5
                    },
                    new Phone
                    {
                        PhoneId = 6,
                        PhoneNumber = "122-555-0189",
                        PhoneNumberTypeId = 3,
                        UserId = 6
                    },
                    new Phone
                    {
                        PhoneId = 7,
                        PhoneNumber = "181-555-0156",
                        PhoneNumberTypeId = 3,
                        UserId = 7
                    },
                    new Phone
                    {
                        PhoneId = 8,
                        PhoneNumber = "815-555-0138",
                        PhoneNumberTypeId = 1,
                        UserId = 8
                    },
                    new Phone
                    {
                        PhoneId = 9,
                        PhoneNumber = "185-555-0186",
                        PhoneNumberTypeId = 1,
                        UserId = 9
                    },
                    new Phone
                    {
                        PhoneId = 10,
                        PhoneNumber = "330-555-2568",
                        PhoneNumberTypeId = 3,
                        UserId = 10
                    },
                    new Phone
                    {
                        PhoneId = 11,
                        PhoneNumber = "719-555-0181",
                        PhoneNumberTypeId = 1,
                        UserId = 11
                    },
                    new Phone
                    {
                        PhoneId = 12,
                        PhoneNumber = "168-555-0183",
                        PhoneNumberTypeId = 3,
                        UserId = 12
                    },
                    new Phone
                    {
                        PhoneId = 13,
                        PhoneNumber = "473-555-0117",
                        PhoneNumberTypeId = 3,
                        UserId = 13
                    },
                    new Phone
                    {
                        PhoneId = 14,
                        PhoneNumber = "465-555-0156",
                        PhoneNumberTypeId = 1,
                        UserId = 14
                    },
                    new Phone
                    {
                        PhoneId = 15,
                        PhoneNumber = "970-555-0138",
                        PhoneNumberTypeId = 1,
                        UserId = 15
                    },
                    new Phone
                    {
                        PhoneId = 16,
                        PhoneNumber = "913-555-0172",
                        PhoneNumberTypeId = 3,
                        UserId = 16
                    },
                    new Phone
                    {
                        PhoneId = 17,
                        PhoneNumber = "150-555-0189",
                        PhoneNumberTypeId = 1,
                        UserId = 17
                    },
                    new Phone
                    {
                        PhoneId = 18,
                        PhoneNumber = "486-555-0150",
                        PhoneNumberTypeId = 3,
                        UserId = 18
                    },
                    new Phone
                    {
                        PhoneId = 19,
                        PhoneNumber = "124-555-0114",
                        PhoneNumberTypeId = 1,
                        UserId = 19
                    },
                    new Phone
                    {
                        PhoneId = 20,
                        PhoneNumber = "708-555-0141",
                        PhoneNumberTypeId = 3,
                        UserId = 20
                    }
                    );



                context.SaveChanges();
            }
        }
    }
}
