﻿using System;
using System.Linq;

namespace Genesis.Net.Common
{
    public enum Iso3166CountryCodes
    {
        /// <summary>
        /// Afghanistan
        /// </summary>
        AF,

        /// <summary>
        /// Aland Islands
        /// </summary>
        AX,

        /// <summary>
        /// Albania
        /// </summary>
        AL,

        /// <summary>
        /// Algeria
        /// </summary>
        DZ,

        /// <summary>
        /// American Samoa
        /// </summary>
        AS,

        /// <summary>
        /// Andorra
        /// </summary>
        AD,

        /// <summary>
        /// Angola
        /// </summary>
        AO,

        /// <summary>
        /// Anguilla
        /// </summary>
        AI,

        /// <summary>
        /// Antarctica
        /// </summary>
        AQ,

        /// <summary>
        /// Antigua And Barbuda
        /// </summary>
        AG,
        
        /// <summary>
        /// Argentina
        /// </summary>
        AR,
        
        /// <summary>
        /// Armenia
        /// </summary>
        AM,
        
        /// <summary>
        /// Aruba
        /// </summary>
        AW,
        
        /// <summary>
        /// Australia
        /// </summary>
        AU,
        
        /// <summary>
        /// Austria
        /// </summary>
        AT,
        
        /// <summary>
        /// Azerbaijan
        /// </summary>
        AZ,
        
        /// <summary>
        /// Bahamas
        /// </summary>
        BS,
        
        /// <summary>
        /// Bahrain
        /// </summary>
        BH,
        
        /// <summary>
        /// Bangladesh
        /// </summary>
        BD,
        
        /// <summary>
        /// Barbados
        /// </summary>
        BB,
        
        /// <summary>
        /// Belarus
        /// </summary>
        BY,
        
        /// <summary>
        /// Belgium
        /// </summary>
        BE,
        
        /// <summary>
        /// Belize
        /// </summary>
        BZ,
        
        /// <summary>
        /// Benin
        /// </summary>
        BJ,

        /// <summary>
        /// Bermuda
        /// </summary>
        BM,
        
        /// <summary>
        /// Bhutan
        /// </summary>
        BT,
        
        /// <summary>
        /// Bolivia
        /// </summary>
        BO,
        
        /// <summary>
        /// Bosnia And Herzegovina
        /// </summary>
        BA,
        
        /// <summary>
        /// Botswana
        /// </summary>
        BW,
        
        /// <summary>
        /// Bouvet Island
        /// </summary>
        BV,
        
        /// <summary>
        /// Brazil
        /// </summary>
        BR,
        
        /// <summary>
        /// British Indian Ocean Territory
        /// </summary>
        IO,
        
        /// <summary>
        /// Brunei Darussalam
        /// </summary>
        BN,
        
        /// <summary>
        /// Bulgaria
        /// </summary>
        BG,
        
        /// <summary>
        /// Burkina Faso
        /// </summary>
        BF,
        
        /// <summary>
        /// Burundi
        /// </summary>
        BI,
        
        /// <summary>
        /// Cambodia
        /// </summary>
        KH,
        
        /// <summary>
        /// Cameroon
        /// </summary>
        CM,
        
        /// <summary>
        /// Canada
        /// </summary>
        CA,
        
        /// <summary>
        /// Cape Verde
        /// </summary>
        CV,
        
        /// <summary>
        /// Cayman Islands
        /// </summary>
        KY,
        
        /// <summary>
        /// Central African Republic
        /// </summary>
        CF,
        
        /// <summary>
        /// Chad
        /// </summary>
        TD,
        
        /// <summary>
        /// Chile
        /// </summary>
        CL,
        
        /// <summary>
        /// China
        /// </summary>
        CN,
        
        /// <summary>
        /// Christmas Island
        /// </summary>
        CX,
        
        /// <summary>
        /// Cocos (Keeling) Islands
        /// </summary>
        CC,
        
        /// <summary>
        /// Colombia
        /// </summary>
        CO,

        /// <summary>
        /// Comoros
        /// </summary>
        KM,
        
        /// <summary>
        /// Congo
        /// </summary>
        CG,
        
        /// <summary>
        /// Congo, Democratic Republic
        /// </summary>
        CD,
        
        /// <summary>
        /// Cook Islands
        /// </summary>
        CK,
        
        /// <summary>
        /// Costa Rica
        /// </summary>
        CR,
        
        /// <summary>
        /// Cote D\'Ivoire
        /// </summary>
        CI,
        
        /// <summary>
        /// Croatia
        /// </summary>
        HR,

        /// <summary>
        /// Cuba
        /// </summary>
        CU,

        /// <summary>
        /// Cyprus
        /// </summary>
        CY,
        
        /// <summary>
        /// Czech Republic
        /// </summary>
        CZ,
        
        /// <summary>
        /// Denmark
        /// </summary>
        DK,
        
        /// <summary>
        /// Djibouti
        /// </summary>
        DJ,
        
        /// <summary>
        /// Dominica
        /// </summary>
        DM,
        
        /// <summary>
        /// Dominican Republic
        /// </summary>
        DO,
        
        /// <summary>
        /// Ecuador
        /// </summary>
        EC,
        
        /// <summary>
        /// Egypt
        /// </summary>
        EG,
        
        /// <summary>
        /// El Salvador
        /// </summary>
        SV,
        
        /// <summary>
        /// Equatorial Guinea
        /// </summary>
        GQ,
        
        /// <summary>
        /// Eritrea
        /// </summary>
        ER,
        
        /// <summary>
        /// Estonia
        /// </summary>
        EE,
        
        /// <summary>
        /// Ethiopia
        /// </summary>
        ET,
        
        /// <summary>
        /// Falkland Islands (Malvinas)
        /// </summary>
        FK,
        
        /// <summary>
        /// Faroe Islands
        /// </summary>
        FO,
        
        /// <summary>
        /// Fiji
        /// </summary>
        FJ,
        
        /// <summary>
        /// Finland
        /// </summary>
        FI,

        /// <summary>
        /// France
        /// </summary>
        FR,
        
        /// <summary>
        /// French Guiana
        /// </summary>
        GF,
        
        /// <summary>
        /// French Polynesia
        /// </summary>
        PF,
        
        /// <summary>
        /// French Southern Territories
        /// </summary>
        TF,
        
        /// <summary>
        /// Gabon
        /// </summary>
        GA,
        
        /// <summary>
        /// Gambia
        /// </summary>
        GM,
        
        /// <summary>
        /// Georgia
        /// </summary>
        GE,
        
        /// <summary>
        /// Germany
        /// </summary>
        DE,
        
        /// <summary>
        /// Ghana
        /// </summary>
        GH,
        
        /// <summary>
        /// Gibraltar
        /// </summary>
        GI,
        
        /// <summary>
        /// Greece
        /// </summary>
        GR,
        
        /// <summary>
        /// Greenland
        /// </summary>
        GL,
        
        /// <summary>
        /// Grenada
        /// </summary>
        GD,
        
        /// <summary>
        /// Guadeloupe
        /// </summary>
        GP,
        
        /// <summary>
        /// Guam
        /// </summary>
        GU,
        
        /// <summary>
        /// Guatemala
        /// </summary>
        GT,
        
        /// <summary>
        /// Guernsey
        /// </summary>
        GG,
        
        /// <summary>
        /// Guinea
        /// </summary>
        GN,
        
        /// <summary>
        /// Guinea-Bissau
        /// </summary>
        GW,

        /// <summary>
        /// Guyana
        /// </summary>
        GY,
        
        /// <summary>
        /// Haiti
        /// </summary>
        HT,
        
        /// <summary>
        /// Heard Island & Mcdonald Islands
        /// </summary>
        HM,
        
        /// <summary>
        /// Holy See (Vatican City State)
        /// </summary>
        VA,
        
        /// <summary>
        /// Honduras
        /// </summary>
        HN,
        
        /// <summary>
        /// Hong Kong
        /// </summary>
        HK,
        
        /// <summary>
        /// Hungary
        /// </summary>
        HU,
        
        /// <summary>
        /// Iceland
        /// </summary>
        IS,
        
        /// <summary>
        /// India
        /// </summary>
        IN,

        /// <summary>
        /// Indonesia
        /// </summary>
        ID,
        
        /// <summary>
        /// Iran, Islamic Republic Of
        /// </summary>
        IR,
        
        /// <summary>
        /// Iraq
        /// </summary>
        IQ,
        
        /// <summary>
        /// Ireland
        /// </summary>
        IE,
        
        /// <summary>
        /// Isle Of Man
        /// </summary>
        IM,
        
        /// <summary>
        /// Israel
        /// </summary>
        IL,
        
        /// <summary>
        /// Italy
        /// </summary>
        IT,
        
        /// <summary>
        /// Jamaica
        /// </summary>
        JM,
        
        /// <summary>
        /// Japan
        /// </summary>
        JP,
        
        /// <summary>
        /// Jersey
        /// </summary>
        JE,
        
        /// <summary>
        /// Jordan
        /// </summary>
        JO,
        
        /// <summary>
        /// Kazakhstan
        /// </summary>
        KZ,
        
        /// <summary>
        /// Kenya
        /// </summary>
        KE,
        
        /// <summary>
        /// Kiribati
        /// </summary>
        KI,
        
        /// <summary>
        /// Korea
        /// </summary>
        KR,
        
        /// <summary>
        /// Kuwait
        /// </summary>
        KW,
        
        /// <summary>
        /// Kyrgyzstan
        /// </summary>
        KG,
        
        /// <summary>
        /// Lao People\'s Democratic Republic
        /// </summary>
        LA,
        
        /// <summary>
        /// Latvia
        /// </summary>
        LV,
        
        /// <summary>
        /// Lebanon
        /// </summary>
        LB,
        
        /// <summary>
        /// Lesotho
        /// </summary>
        LS,
        
        /// <summary>
        /// Liberia
        /// </summary>
        LR,
        
        /// <summary>
        /// Libyan Arab Jamahiriya
        /// </summary>
        LY,
        
        /// <summary>
        /// Liechtenstein
        /// </summary>
        LI,

        /// <summary>
        /// Lithuania
        /// </summary>
        LT,
        
        /// <summary>
        /// Luxembourg
        /// </summary>
        LU,
        
        /// <summary>
        /// Macao
        /// </summary>
        MO,
        
        /// <summary>
        /// Macedonia
        /// </summary>
        MK,
        
        /// <summary>
        /// Madagascar
        /// </summary>
        MG,
        
        /// <summary>
        /// Malawi
        /// </summary>
        MW,
        
        /// <summary>
        /// Malaysia
        /// </summary>
        MY,
        
        /// <summary>
        /// Maldives
        /// </summary>
        MV,
        
        /// <summary>
        /// Mali
        /// </summary>
        ML,
        
        /// <summary>
        /// Malta
        /// </summary>
        MT,
        
        /// <summary>
        /// Marshall Islands
        /// </summary>
        MH,
        
        /// <summary>
        /// Martinique
        /// </summary>
        MQ,
        
        /// <summary>
        /// Mauritania
        /// </summary>
        MR,

        /// <summary>
        /// Mauritius
        /// </summary>
        MU,
        
        /// <summary>
        /// Mayotte
        /// </summary>
        YT,
        
        /// <summary>
        /// Mexico
        /// </summary>
        MX,
        
        /// <summary>
        /// Micronesia, Federated States Of
        /// </summary>
        FM,
        
        /// <summary>
        /// Moldova
        /// </summary>
        MD,
        
        /// <summary>
        /// Monaco
        /// </summary>
        MC,
        
        /// <summary>
        /// Mongolia
        /// </summary>
        MN,
        
        /// <summary>
        /// Montenegro
        /// </summary>
        ME,
        
        /// <summary>
        /// Montserrat
        /// </summary>
        MS,
        
        /// <summary>
        /// Morocco
        /// </summary>
        MA,
        
        /// <summary>
        /// Mozambique
        /// </summary>
        MZ,
        
        /// <summary>
        /// Myanmar
        /// </summary>
        MM,
        
        /// <summary>
        /// Namibia
        /// </summary>
        NA,
        
        /// <summary>
        /// Nauru
        /// </summary>
        NR,
        
        /// <summary>
        /// Nepal
        /// </summary>
        NP,
        
        /// <summary>
        /// Netherlands
        /// </summary>
        NL,
        
        /// <summary>
        /// Netherlands Antilles
        /// </summary>
        AN,
        
        /// <summary>
        /// New Caledonia
        /// </summary>
        NC,

        /// <summary>
        /// New Zealand
        /// </summary>
        NZ,
        
        /// <summary>
        /// Nicaragua
        /// </summary>
        NI,
        
        /// <summary>
        /// Niger
        /// </summary>
        NE,
        
        /// <summary>
        /// Nigeria
        /// </summary>
        NG,
        
        /// <summary>
        /// Niue
        /// </summary>
        NU,
        
        /// <summary>
        /// Norfolk Island
        /// </summary>
        NF,
        
        /// <summary>
        /// Northern Mariana Islands
        /// </summary>
        MP,
        
        /// <summary>
        /// Norway
        /// </summary>
        NO,
        
        /// <summary>
        /// Oman
        /// </summary>
        OM,
        
        /// <summary>
        /// Pakistan
        /// </summary>
        PK,
        
        /// <summary>
        /// Palau
        /// </summary>
        PW,
        
        /// <summary>
        /// Palestinian Territory, Occupied
        /// </summary>
        PS,
        
        /// <summary>
        /// Panama
        /// </summary>
        PA,
        
        /// <summary>
        /// Papua New Guinea
        /// </summary>
        PG,
        
        /// <summary>
        /// Paraguay
        /// </summary>
        PY,
        
        /// <summary>
        /// Peru
        /// </summary>
        PE,
        
        /// <summary>
        /// Philippines
        /// </summary>
        PH,
        
        /// <summary>
        /// Pitcairn
        /// </summary>
        PN,
        
        /// <summary>
        /// Poland
        /// </summary>
        PL,
        
        /// <summary>
        /// Portugal
        /// </summary>
        PT,
        
        /// <summary>
        /// Puerto Rico
        /// </summary>
        PR,
        
        /// <summary>
        /// Qatar
        /// </summary>
        QA,
        
        /// <summary>
        /// Reunion
        /// </summary>
        RE,
        
        /// <summary>
        /// Romania
        /// </summary>
        RO,
        
        /// <summary>
        /// Russian Federation
        /// </summary>
        RU,
        
        /// <summary>
        /// Rwanda
        /// </summary>
        RW,
        
        /// <summary>
        /// Saint Barthelemy
        /// </summary>
        BL,
        
        /// <summary>
        /// Saint Helena
        /// </summary>
        SH,
        
        /// <summary>
        /// Saint Kitts And Nevis
        /// </summary>
        KN,
        
        /// <summary>
        /// Saint Lucia
        /// </summary>
        LC,
        
        /// <summary>
        /// Saint Martin
        /// </summary>
        MF,
        
        /// <summary>
        /// Saint Pierre And Miquelon
        /// </summary>
        PM,
        
        /// <summary>
        /// Saint Vincent And Grenadines
        /// </summary>
        VC,
        
        /// <summary>
        /// Samoa
        /// </summary>
        WS,
        
        /// <summary>
        /// San Marino
        /// </summary>
        SM,
        
        /// <summary>
        /// Sao Tome And Principe
        /// </summary>
        ST,
        
        /// <summary>
        /// Saudi Arabia
        /// </summary>
        SA,
        
        /// <summary>
        /// Senegal
        /// </summary>
        SN,
        
        /// <summary>
        /// Serbia
        /// </summary>
        RS,
        
        /// <summary>
        /// Seychelles
        /// </summary>
        SC,
        
        /// <summary>
        /// Sierra Leone
        /// </summary>
        SL,
        
        /// <summary>
        /// Singapore
        /// </summary>
        SG,
        
        /// <summary>
        /// Slovakia
        /// </summary>
        SK,
        
        /// <summary>
        /// Slovenia
        /// </summary>
        SI,
        
        /// <summary>
        /// Solomon Islands
        /// </summary>
        SB,
        
        /// <summary>
        /// Somalia
        /// </summary>
        SO,
        
        /// <summary>
        /// South Africa
        /// </summary>
        ZA,
        
        /// <summary>
        /// South Georgia And Sandwich Isl.
        /// </summary>
        GS,
        
        /// <summary>
        /// Spain
        /// </summary>
        ES,

        /// <summary>
        /// Sri Lanka
        /// </summary>
        LK,
        
        /// <summary>
        /// Sudan
        /// </summary>
        SD,
        
        /// <summary>
        /// Suriname
        /// </summary>
        SR,
        
        /// <summary>
        /// Svalbard And Jan Mayen
        /// </summary>
        SJ,
        
        /// <summary>
        /// Swaziland
        /// </summary>
        SZ,
        
        /// <summary>
        /// Sweden
        /// </summary>
        SE,
        
        /// <summary>
        /// Switzerland
        /// </summary>
        CH,
        
        /// <summary>
        /// Syrian Arab Republic
        /// </summary>
        SY,
        
        /// <summary>
        /// Taiwan
        /// </summary>
        TW,
        
        /// <summary>
        /// Tajikistan
        /// </summary>
        TJ,
        
        /// <summary>
        /// Tanzania
        /// </summary>
        TZ,
        
        /// <summary>
        /// Thailand
        /// </summary>
        TH,
        
        /// <summary>
        /// Timor-Leste
        /// </summary>
        TL,
        
        /// <summary>
        /// Togo
        /// </summary>
        TG,
        
        /// <summary>
        /// Tokelau
        /// </summary>
        TK,
        
        /// <summary>
        /// Tonga
        /// </summary>
        TO,
        
        /// <summary>
        /// Trinidad And Tobago
        /// </summary>
        TT,
        
        /// <summary>
        /// Tunisia
        /// </summary>
        TN,

        /// <summary>
        /// Turkey
        /// </summary>
        TR,
        
        /// <summary>
        /// Turkmenistan
        /// </summary>
        TM,
        
        /// <summary>
        /// Turks And Caicos Islands
        /// </summary>
        TC,
        
        /// <summary>
        /// Tuvalu
        /// </summary>
        TV,
        
        /// <summary>
        /// Uganda
        /// </summary>
        UG,
        
        /// <summary>
        /// Ukraine
        /// </summary>
        UA,
        
        /// <summary>
        /// United Arab Emirates
        /// </summary>
        AE,
        
        /// <summary>
        /// United Kingdom
        /// </summary>
        GB,
        
        /// <summary>
        /// United States
        /// </summary>
        US,
        
        /// <summary>
        /// United States Outlying Islands
        /// </summary>
        UM,
        
        /// <summary>
        /// Uruguay
        /// </summary>
        UY,
        
        /// <summary>
        /// Uzbekistan
        /// </summary>
        UZ,
        
        /// <summary>
        /// Vanuatu
        /// </summary>
        VU,
        
        /// <summary>
        /// Venezuela
        /// </summary>
        VE,
        
        /// <summary>
        /// Viet Nam
        /// </summary>
        VN,
        
        /// <summary>
        /// Virgin Islands, British
        /// </summary>
        VG,
        
        /// <summary>
        /// Virgin Islands, U.S.
        /// </summary>
        VI,
        
        /// <summary>
        /// Wallis And Futuna
        /// </summary>
        WF,
        
        /// <summary>
        /// Western Sahara
        /// </summary>
        EH,

        /// <summary>
        /// Yemen
        /// </summary>
        YE,
        
        /// <summary>
        /// Zambia
        /// </summary>
        ZM,

        /// <summary>
        /// Zimbabwe
        /// </summary>
        ZW,
    }
}