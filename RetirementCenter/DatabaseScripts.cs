
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace RetirementCenter
{
    public static class DatabaseScripts
    {

        public static void FireScript()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                //vTBLMashat
                if (CheckViewExists("vTBLMashat"))
                {
                    cmd.CommandText = DropObject("vTBLMashat");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLMashat;
                cmd.ExecuteNonQuery();
                //vTBLEdafat
                if (CheckViewExists("vTBLEdafat"))
                {
                    cmd.CommandText = DropObject("vTBLEdafat");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLEdafat;
                cmd.ExecuteNonQuery();
                //vTBLEdafatWarasa
                if (CheckViewExists("vTBLEdafatWarasa"))
                {
                    cmd.CommandText = DropObject("vTBLEdafatWarasa");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLEdafatWarasa;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry01"))
                {
                    cmd.CommandText = DropObject("vQry01");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry01;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry02"))
                {
                    cmd.CommandText = DropObject("vQry02");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry02;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry02a"))
                {
                    cmd.CommandText = DropObject("vQry02a");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry02a;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vTBLWarasa"))
                {
                    cmd.CommandText = DropObject("vTBLWarasa");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLWarasa;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vTBLWarasa_TBLMashat"))
                {
                    cmd.CommandText = DropObject("vTBLWarasa_TBLMashat");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLWarasa_TBLMashat;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry06"))
                {
                    cmd.CommandText = DropObject("vQry06");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry06;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry07"))
                {
                    cmd.CommandText = DropObject("vQry07");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry07;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry08"))
                {
                    cmd.CommandText = DropObject("vQry08");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry08;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry10"))
                {
                    cmd.CommandText = DropObject("vQry10");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry10;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry11"))
                {
                    cmd.CommandText = DropObject("vQry11");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry11;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry12"))
                {
                    cmd.CommandText = DropObject("vQry12");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry12;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry13"))
                {
                    cmd.CommandText = DropObject("vQry13");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry13;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry14"))
                {
                    cmd.CommandText = DropObject("vQry14");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry14;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry15"))
                {
                    cmd.CommandText = DropObject("vQry15");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry15;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry19"))
                {
                    cmd.CommandText = DropObject("vQry19");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry19;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry20"))
                {
                    cmd.CommandText = DropObject("vQry20");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry20;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vTBLMashat01_V1"))
                {
                    cmd.CommandText = DropObject("vTBLMashat01_V1");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLMashat01_V1;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vTBLMashat01_V2"))
                {
                    cmd.CommandText = DropObject("vTBLMashat01_V2");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLMashat01_V2;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry22"))
                {
                    cmd.CommandText = DropObject("vQry22");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry22;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry23"))
                {
                    cmd.CommandText = DropObject("vQry23");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry23;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry25"))
                {
                    cmd.CommandText = DropObject("vQry25");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry25;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry26"))
                {
                    cmd.CommandText = DropObject("vQry26");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry26;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry27"))
                {
                    cmd.CommandText = DropObject("vQry27");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry27;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry28"))
                {
                    cmd.CommandText = DropObject("vQry28");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry28;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry31"))
                {
                    cmd.CommandText = DropObject("vQry31");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry31;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry32"))
                {
                    cmd.CommandText = DropObject("vQry32");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry32;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry33"))
                {
                    cmd.CommandText = DropObject("vQry33");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry33;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry35"))
                {
                    cmd.CommandText = DropObject("vQry35");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry35;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry42"))
                {
                    cmd.CommandText = DropObject("vQry42");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry42;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry43"))
                {
                    cmd.CommandText = DropObject("vQry43");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry43;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry57"))
                {
                    cmd.CommandText = DropObject("vQry57");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry57;
                cmd.ExecuteNonQuery();

                if (CheckViewExists("vQry58"))
                {
                    cmd.CommandText = DropObject("vQry58");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry58;
                cmd.ExecuteNonQuery();
                //vQry59
                if (CheckViewExists("vQry59"))
                {
                    cmd.CommandText = DropObject("vQry59");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry59;
                cmd.ExecuteNonQuery();
                //TBLProofDoc
                cmd.CommandText = TBLProofDoc;
                cmd.ExecuteNonQuery();
                //BankExportedData
                cmd.CommandText = BankExportedData;
                cmd.ExecuteNonQuery();
                //vTBLDeathMembers
                if (CheckViewExists("vTBLDeathMembers"))
                {
                    cmd.CommandText = DropObject("vTBLDeathMembers");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLDeathMembers;
                cmd.ExecuteNonQuery();
                //vQry71
                if (CheckViewExists("vQry71"))
                {
                    cmd.CommandText = DropObject("vQry71");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry71;
                cmd.ExecuteNonQuery();
                //vQry73
                if (CheckViewExists("vQry73"))
                {
                    cmd.CommandText = DropObject("vQry73");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry73;
                cmd.ExecuteNonQuery();
                //vtbladminremarks
                if (CheckViewExists("vtbladminremarks"))
                {
                    cmd.CommandText = DropObject("vtbladminremarks");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vtbladminremarks;
                cmd.ExecuteNonQuery();
                //vQry74
                if (CheckViewExists("vQry74"))
                {
                    cmd.CommandText = DropObject("vQry74");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry74;
                cmd.ExecuteNonQuery();
                //vQry75
                if (CheckViewExists("vQry75"))
                {
                    cmd.CommandText = DropObject("vQry75");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry75;
                cmd.ExecuteNonQuery();
                //vQry76
                if (CheckViewExists("vQry76"))
                {
                    cmd.CommandText = DropObject("vQry76");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry76;
                cmd.ExecuteNonQuery();
                //vQry77
                if (CheckViewExists("vQry77"))
                {
                    cmd.CommandText = DropObject("vQry77");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry77;
                cmd.ExecuteNonQuery();
                //vTBLEstefa
                if (CheckViewExists("vTBLEstefa"))
                {
                    cmd.CommandText = DropObject("vTBLEstefa");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLEstefa;
                cmd.ExecuteNonQuery();
                //vQry78
                if (CheckViewExists("vQry78"))
                {
                    cmd.CommandText = DropObject("vQry78");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry78;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
        }

        public static bool CheckViewExists(string viewName)
        {
            bool exist = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandText = string.Format(@"IF EXISTS(select * FROM sys.views where name = '{0}')
                                            SELECT 1
                                            ELSE
                                            SELECT 0", viewName);
            try
            {
                con.Open();
                if (cmd.ExecuteScalar().ToString() == "1")
                    exist = true;
                else
                    exist = false;
            }
            catch (SqlException ex)
            {
                Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
            return exist;
        }
        private static string DropObject(string objName)
        {
            return string.Format(@"DROP VIEW [dbo].[{0}]", objName);
        }

        public static string vTBLMashat
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLMashat]
                AS
                SELECT dbo.TBLMashat.MMashatId, dbo.TBLMashat.MMashatNKAPAId, dbo.TBLMashat.MMashatLId, dbo.TBLMashat.MMashatNId, dbo.TBLMashat.MMashatName, 
                dbo.TBLMashat.BirthDate, dbo.TBLMashat.MMashatGender, dbo.TBLMashat.MMashataddresGov, dbo.TBLMashat.MMashataddresMarkez, 
                dbo.TBLMashat.MMashataddres, dbo.TBLMashat.MMashatPhone, dbo.TBLMashat.MMashatMobil, dbo.TBLMashat.MMashatMail, 
                dbo.TBLMashat.WorkeEndDate, dbo.TBLMashat.KideNumber, dbo.TBLMashat.ZmalaEshtrakDate, dbo.TBLMashat.SyndicateId, 
                dbo.TBLMashat.SubCommitteId, dbo.TBLMashat.MemberShipNumber, dbo.TBLMashat.MashHalaId, dbo.TBLMashat.sarfnumber, dbo.TBLMashat.datein, 
                dbo.TBLMashat.userin, dbo.TBLMashat.yasref, dbo.CDSyndicate.Syndicate, dbo.Users.RealName, dbo.CDMashHala.MashHala, 
                dbo.CDSubCommitte.SubCommitte, dbo.TBLMashat.filedate, dbo.TBLMashat.EndworkId, dbo.CDEndwork.EndworkReson, dbo.TBLMashat.visa
                FROM dbo.TBLMashat LEFT OUTER JOIN
                dbo.CDEndwork ON dbo.TBLMashat.EndworkId = dbo.CDEndwork.EndworkId LEFT OUTER JOIN
                dbo.CDSubCommitte ON dbo.TBLMashat.SubCommitteId = dbo.CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                dbo.CDMashHala ON dbo.TBLMashat.MashHalaId = dbo.CDMashHala.MashHalaId LEFT OUTER JOIN
                dbo.CDSyndicate ON dbo.TBLMashat.SyndicateId = dbo.CDSyndicate.SyndicateId LEFT OUTER JOIN
                dbo.Users ON dbo.TBLMashat.userin = dbo.Users.UserID";
            }
        }
        public static string vTBLEdafat
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLEdafat]
                AS
                SELECT        dbo.TBLEdafat.MMashatId, dbo.TBLEdafat.DofatSarfId, dbo.TBLEdafat.sarfTypeId, dbo.TBLEdafat.estktaa, dbo.TBLEdafat.datein, dbo.TBLEdafat.userin, 
                         dbo.Users.RealName, dbo.TBLMashat.MMashatName, dbo.TBLDofatSarf.DofatSarf, dbo.TBLDofatSarf.DofatSarfDatefrom, dbo.TBLDofatSarf.DofatSarfDateto, 
                         dbo.CDsarfType.sarfType, dbo.CDsarfType.feasarf, dbo.CDMashHala.MashHala, dbo.TBLMashat.sarfnumber, dbo.CDSubCommitte.SubCommitte, 
                         dbo.CDSyndicate.Syndicate, dbo.TBLMashat.MMashatNId, dbo.TBLMashat.KideNumber, dbo.TBLMashat.SyndicateId, dbo.TBLMashat.SubCommitteId, 
                         dbo.TBLMashat.WorkeEndDate
                         FROM            dbo.CDSubCommitte RIGHT OUTER JOIN
                         dbo.TBLMashat ON dbo.CDSubCommitte.SubCommitteId = dbo.TBLMashat.SubCommitteId LEFT OUTER JOIN
                         dbo.CDSyndicate ON dbo.TBLMashat.SyndicateId = dbo.CDSyndicate.SyndicateId RIGHT OUTER JOIN
                         dbo.CDMashHala RIGHT OUTER JOIN
                         dbo.CDsarfType ON dbo.CDMashHala.MashHalaId = dbo.CDsarfType.MashHalaId RIGHT OUTER JOIN
                         dbo.TBLEdafat LEFT OUTER JOIN
                         dbo.TBLDofatSarf ON dbo.TBLEdafat.DofatSarfId = dbo.TBLDofatSarf.DofatSarfId ON 
                         dbo.CDsarfType.sarfTypeId = dbo.TBLEdafat.sarfTypeId LEFT OUTER JOIN
                         dbo.Users ON dbo.TBLEdafat.userin = dbo.Users.UserID ON dbo.TBLMashat.MMashatId = dbo.TBLEdafat.MMashatId";
            }
        }
        public static string vTBLEdafatWarasa
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLEdafatWarasa]
                AS
                SELECT        dbo.Users.RealName, dbo.TBLMashat.MMashatName, dbo.TBLDofatSarf.DofatSarf, dbo.TBLDofatSarf.DofatSarfDatefrom, dbo.TBLDofatSarf.DofatSarfDateto, dbo.CDsarfType.sarfType, dbo.CDsarfType.feasarf, 
                         dbo.TBLMashat.sarfnumber, dbo.CDSubCommitte.SubCommitte, dbo.CDSyndicate.Syndicate, dbo.TBLEdafatWarsa.PersonId, dbo.TBLEdafatWarsa.DofatSarfId, dbo.TBLEdafatWarsa.datesarf, 
                         dbo.TBLEdafatWarsa.sarfTypeId, dbo.TBLEdafatWarsa.estktaa, dbo.TBLEdafatWarsa.datein, dbo.TBLEdafatWarsa.userin, dbo.TBLWarasa.personName, dbo.TBLWarasa.yasref, dbo.TBLWarasa.SyndicateId, 
                         dbo.TBLWarasa.SubCommitteId
                FROM            dbo.CDsarfType INNER JOIN
                         dbo.CDSyndicate INNER JOIN
                         dbo.CDSubCommitte INNER JOIN
                         dbo.TBLWarasa ON dbo.CDSubCommitte.SubCommitteId = dbo.TBLWarasa.SubCommitteId INNER JOIN
                         dbo.TBLEdafatWarsa ON dbo.TBLWarasa.PersonId = dbo.TBLEdafatWarsa.PersonId INNER JOIN
                         dbo.TBLDofatSarf ON dbo.TBLEdafatWarsa.DofatSarfId = dbo.TBLDofatSarf.DofatSarfId INNER JOIN
                         dbo.Users ON dbo.TBLEdafatWarsa.userin = dbo.Users.UserID ON dbo.CDSyndicate.SyndicateId = dbo.TBLWarasa.SyndicateId INNER JOIN
                         dbo.TBLMashat ON dbo.TBLWarasa.MMashatId = dbo.TBLMashat.MMashatId ON dbo.CDsarfType.sarfTypeId = dbo.TBLEdafatWarsa.sarfTypeId";
            }
        }
        public static string vTBLWarasa
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLWarasa]
                AS
                SELECT        dbo.TBLWarasa.PersonId, dbo.TBLWarasa.MMashatId, dbo.TBLWarasa.WarasaTypeId, dbo.TBLWarasa.personName, dbo.TBLWarasa.personNID, 
                         dbo.TBLWarasa.personbirth, dbo.TBLWarasa.personAddres, dbo.TBLWarasa.personmobile, dbo.TBLWarasa.yasref, dbo.TBLWarasa.userin, 
                         dbo.TBLWarasa.datein, dbo.TBLMashat.MMashatName, dbo.CDWarasaType.WarasaType, dbo.Users.RealName, dbo.TBLWarasa.visa
FROM            dbo.TBLWarasa LEFT OUTER JOIN
                         dbo.TBLMashat ON dbo.TBLWarasa.MMashatId = dbo.TBLMashat.MMashatId LEFT OUTER JOIN
                         dbo.CDWarasaType ON dbo.TBLWarasa.WarasaTypeId = dbo.CDWarasaType.WarasaTypeId LEFT OUTER JOIN
                         dbo.Users ON dbo.TBLWarasa.userin = dbo.Users.UserID";
            }
        }
        public static string vTBLWarasa_TBLMashat
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLWarasa_TBLMashat]
                AS
                SELECT        dbo.TBLWarasa.PersonId, dbo.TBLWarasa.MMashatId, dbo.TBLWarasa.WarasaTypeId, dbo.TBLWarasa.personName, dbo.TBLWarasa.personNID, dbo.TBLWarasa.personbirth, dbo.TBLWarasa.personAddres, 
                         dbo.TBLWarasa.personmobile, dbo.TBLWarasa.yasref, dbo.TBLWarasa.userin, dbo.TBLWarasa.datein, dbo.Users.RealName, dbo.CDWarasaType.WarasaType, dbo.TBLMashat.MMashatName, 
                         dbo.TBLMashat.sarfnumber, CDSyndicate_1.Syndicate, dbo.CDSubCommitte.SubCommitte, dbo.TBLMashat.SyndicateId, dbo.TBLMashat.SubCommitteId, dbo.CDEndwork.EndworkReson, 
                         dbo.TBLMashat.EndworkId, dbo.TBLMashat.WorkeEndDate, dbo.TBLWarasa.SyndicateId AS SyndicateIdWarasa, dbo.TBLWarasa.SubCommitteId AS SubCommitteIdWarasa, 
                         dbo.CDSyndicate.Syndicate AS SyndicateWarasa, CDSubCommitte_1.SubCommitte AS SubCommitteWarasa, dbo.TBLWarasa.responsiblesarf, dbo.TBLWarasa.visa, YEAR(GETDATE()) 
                         - CAST(CASE WHEN SUBSTRING(TBLWarasa.personNID, 1, 1) = '2' THEN '19' ELSE '20' END + SUBSTRING(dbo.TBLWarasa.personNID, 2, 2) AS INT) AS Age
						 ,TBL.personName AS responsiblesarfName
FROM            dbo.CDSubCommitte RIGHT OUTER JOIN
                         dbo.Users RIGHT OUTER JOIN
                         dbo.CDSyndicate RIGHT OUTER JOIN
                         dbo.TBLWarasa LEFT OUTER JOIN
                         dbo.CDSubCommitte AS CDSubCommitte_1 ON dbo.TBLWarasa.SubCommitteId = CDSubCommitte_1.SubCommitteId ON dbo.CDSyndicate.SyndicateId = dbo.TBLWarasa.SyndicateId LEFT OUTER JOIN
                         dbo.TBLMashat LEFT OUTER JOIN
                         dbo.CDSyndicate AS CDSyndicate_1 ON dbo.TBLMashat.SyndicateId = CDSyndicate_1.SyndicateId ON dbo.TBLWarasa.MMashatId = dbo.TBLMashat.MMashatId LEFT OUTER JOIN
                         dbo.CDWarasaType ON dbo.TBLWarasa.WarasaTypeId = dbo.CDWarasaType.WarasaTypeId ON dbo.Users.UserID = dbo.TBLWarasa.userin LEFT OUTER JOIN
                         dbo.CDEndwork ON dbo.TBLMashat.EndworkId = dbo.CDEndwork.EndworkId ON dbo.CDSubCommitte.SubCommitteId = dbo.TBLMashat.SubCommitteId
						 LEFT OUTER JOIN dbo.TBLWarasa TBL ON TBLWarasa.responsiblesarfId = TBL.PersonId
";
            }
        }
        public static string vQry01
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry01]
                AS
                SELECT COUNT(MMashatName) AS counting, MMashatName, SyndicateId,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLMashat.SyndicateId) AS Syndicate
                FROM TBLMashat WHERE
                (SELECT COUNT(*) FROM TBLMashat AS tbl1 WHERE MMashatName = TBLMashat.MMashatName AND SyndicateId = TBLMashat.SyndicateId) > 1
                GROUP BY MMashatName, SyndicateId";
            }
        }
        public static string vQry02
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry02]
                AS
                SELECT COUNT(sarfnumber) AS counting, sarfnumber, SyndicateId,
                (SELECT Syndicate FROM dbo.CDSyndicate WHERE (SyndicateId = dbo.TBLMashat.SyndicateId)) AS Syndicate
                FROM dbo.TBLMashat WHERE MashHalaId = 1 AND
                ((SELECT COUNT(*) FROM dbo.TBLMashat AS tbl1
                WHERE (sarfnumber = dbo.TBLMashat.sarfnumber) AND (SyndicateId = dbo.TBLMashat.SyndicateId)) > 1)
                GROUP BY sarfnumber, SyndicateId";
            }
        }
        public static string vQry02a
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry02a]
                AS
                SELECT COUNT(sarfnumber) AS counting, sarfnumber, SyndicateId,
                (SELECT Syndicate FROM dbo.CDSyndicate WHERE (SyndicateId = dbo.TBLMashat.SyndicateId)) AS Syndicate
                FROM dbo.TBLMashat WHERE MashHalaId = 2 AND
                ((SELECT COUNT(*) FROM dbo.TBLMashat AS tbl1
                WHERE (sarfnumber = dbo.TBLMashat.sarfnumber) AND (SyndicateId = dbo.TBLMashat.SyndicateId)) > 1)
                GROUP BY sarfnumber, SyndicateId";
            }
        }
        public static string vQry06
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry06]
                AS
                SELECT PersonId, MMashatId, WarasaTypeId, personName, personNID, yasref, datein, SyndicateId, 
                (SELECT RealName FROM Users WHERE UserID = TBLWarasa.userin) as RealName,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLWarasa.SyndicateId) as SyndicateW,
                (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLWarasa.SubCommitteId) as SubCommitteW,
                (SELECT MMashatName FROM TBLMashat WHERE MMashatId = TBLWarasa.MMashatId) as MMashatName,
                (SELECT sarfnumber FROM TBLMashat WHERE MMashatId = TBLWarasa.MMashatId) as sarfnumber,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = (SELECT SyndicateId FROM TBLWarasa as tblsw WHERE PersonId = TBLWarasa.responsiblesarfId)) as SyndicateR,
                (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = (SELECT SyndicateId FROM TBLWarasa as tblsw WHERE PersonId = TBLWarasa.responsiblesarfId)) as SubCommitteR
                FROM TBLWarasa WHERE responsiblesarf = 0 AND
                EXISTS(SELECT PersonId FROM TBLWarasa as tblw WHERE PersonId = TBLWarasa.responsiblesarfId AND SubCommitteId <> TBLWarasa.SubCommitteId)";
            }
        }
        public static string vQry07
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry07]
                AS
                SELECT PersonId, MMashatId, WarasaTypeId, personName, personNID, yasref, datein, SyndicateId,
                (SELECT RealName FROM Users WHERE UserID = TBLWarasa.userin) as RealName,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLWarasa.SyndicateId) as SyndicateW,
                (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLWarasa.SubCommitteId) as SubCommitteW,
                (SELECT MMashatName FROM TBLMashat WHERE MMashatId = TBLWarasa.MMashatId) as MMashatName,
                (SELECT sarfnumber FROM TBLMashat WHERE MMashatId = TBLWarasa.MMashatId) as sarfnumber,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = (SELECT SyndicateId FROM TBLMashat as tblsM WHERE MMashatId = TBLWarasa.MMashatId)) as SyndicateR,
                (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = (SELECT SyndicateId FROM TBLMashat as tblsM WHERE MMashatId = TBLWarasa.MMashatId)) as SubCommitteR
                FROM TBLWarasa WHERE yasref = 1 AND
                EXISTS(SELECT MMashatId FROM TBLMashat WHERE MMashatId = TBLWarasa.MMashatId AND yasref = 0)";
            }
        }
        public static string vQry08
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry08]
                AS
                SELECT PersonId, MMashatId, WarasaTypeId, personName, personNID, yasref, datein, SyndicateId,
                (SELECT RealName FROM Users WHERE UserID = TBLWarasa.userin) as RealName,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLWarasa.SyndicateId) as SyndicateW,
                (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLWarasa.SubCommitteId) as SubCommitteW,
                (SELECT MMashatName FROM TBLMashat WHERE MMashatId = TBLWarasa.MMashatId) as MMashatName,
                (SELECT sarfnumber FROM TBLMashat WHERE MMashatId = TBLWarasa.MMashatId) as sarfnumber,
                (SELECT personName FROM TBLWarasa as TBLWS WHERE PersonId = TBLWarasa.responsiblesarfId) AS personNameR
                 FROM TBLWarasa WHERE responsiblesarf = 1 AND responsiblesarfId <> PersonId";
            }
        }
        public static string vQry10
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry10]
                AS
                SELECT        ISNULL(SUM(TBLWarasaSarf.monymonth), 0) AS monymonth, ISNULL(SUM(TBLWarasaSarf.rsmmonth), 0) AS rsmmonth, 
                ISNULL(SUM(TBLWarasaSarf.eshtrakmonth), 0) AS eshtrakmonth, ISNULL(SUM(TBLWarasaSarf.estktaa), 0) AS estktaa, TBLDofatSarf.DofatSarf, 
                TBLMashat.MMashatName, CDSubCommitte.SubCommitte, CDSyndicate.Syndicate, TBLMashat.sarfnumber, TBLMashat.MMashatId
                FROM            TBLDofatSarf RIGHT OUTER JOIN
                TBLWarasaSarf RIGHT OUTER JOIN
                CDSubCommitte RIGHT OUTER JOIN
                TBLMashat LEFT OUTER JOIN
                TBLWarasa ON TBLMashat.MMashatId = TBLWarasa.MMashatId ON CDSubCommitte.SubCommitteId = TBLMashat.SubCommitteId LEFT OUTER JOIN
                CDSyndicate ON TBLMashat.SyndicateId = CDSyndicate.SyndicateId ON TBLWarasaSarf.PersonId = TBLWarasa.PersonId ON 
                TBLDofatSarf.DofatSarfId = TBLWarasaSarf.DofatSarfId
                GROUP BY TBLDofatSarf.DofatSarf, TBLMashat.MMashatName, CDSubCommitte.SubCommitte, CDSyndicate.Syndicate, TBLMashat.sarfnumber, TBLMashat.MMashatId";
            }
        }
        public static string vQry11
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry11]
                AS
                SELECT TBLSarfExpetion.DofatSarfId, TBLSarfExpetion.PersonId, TBLSarfExpetion.wmonymonth, TBLSarfExpetion.wrsmmonth, TBLSarfExpetion.reemark, 
                TBLDofatSarf.DofatSarf, TBLWarasa.personName, TBLWarasa.SyndicateId, TBLWarasa.SubCommitteId, CDSyndicate.Syndicate, 
                CDSubCommitte.SubCommitte, TBLMashat.MMashatName, TBLMashat.sarfnumber
                FROM            TBLWarasa LEFT OUTER JOIN
                TBLMashat ON TBLWarasa.MMashatId = TBLMashat.MMashatId LEFT OUTER JOIN
                CDSubCommitte ON TBLWarasa.SubCommitteId = CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                CDSyndicate ON TBLWarasa.SyndicateId = CDSyndicate.SyndicateId RIGHT OUTER JOIN
                TBLSarfExpetion ON TBLWarasa.PersonId = TBLSarfExpetion.PersonId LEFT OUTER JOIN
                TBLDofatSarf ON TBLSarfExpetion.DofatSarfId = TBLDofatSarf.DofatSarfId";
            }
        }
        public static string vQry12
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry12]
                AS
                SELECT dbo.TBLWarasa.PersonId, dbo.TBLWarasa.MMashatId, dbo.TBLWarasa.WarasaTypeId, dbo.TBLWarasa.personName, dbo.TBLWarasa.SyndicateId, 
                dbo.TBLWarasa.SubCommitteId, dbo.TBLWarasa.responsiblesarf, dbo.TBLWarasa.responsiblesarfId, dbo.CDWarasaType.WarasaType, 
                dbo.TBLWarasa.yasref, dbo.TBLMashat.MMashatName, dbo.TBLMashat.sarfnumber, dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte
                FROM dbo.TBLWarasa LEFT OUTER JOIN
                dbo.TBLMashat ON dbo.TBLWarasa.MMashatId = dbo.TBLMashat.MMashatId LEFT OUTER JOIN
                dbo.CDWarasaType ON dbo.TBLWarasa.WarasaTypeId = dbo.CDWarasaType.WarasaTypeId LEFT OUTER JOIN
                dbo.CDSubCommitte ON dbo.TBLWarasa.SubCommitteId = dbo.CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                dbo.CDSyndicate ON dbo.TBLWarasa.SyndicateId = dbo.CDSyndicate.SyndicateId
                WHERE (dbo.TBLWarasa.responsiblesarf = 0) AND (NOT EXISTS
                (SELECT PersonId FROM dbo.TBLWarasa AS TBLS WHERE (MMashatId = dbo.TBLWarasa.MMashatId) AND (responsiblesarf = 1)))";
            }
        }
        public static string vQry13
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry13]
                AS
                WITH XXX (PersonId, MMashatId, monymonth)
                AS
                (
                SELECT PersonId, (SELECT MMashatId FROM TBLWarasa WHERE PersonId = TBLWarasaSarf.PersonId) AS MMashatId,
                (SELECT ISNULL(SUM(monymonth), 0) FROM TBLWarasaSarf AS tblw WHERE  Edafat = TBLWarasaSarf.Edafat AND
                EXISTS(select PersonId FROM TBLWarasa WHERE PersonId = tblw.PersonId AND responsiblesarfId = TBLWarasaSarf.PersonId)) as monymonth
                FROM TBLWarasaSarf
                WHERE DofatSarfId = 1 AND Edafat = 0 
                --AND EXISTS(SELECT PersonId FROM TBLWarasa WHERE PersonId = TBLWarasaSarf.PersonId AND SubCommitteId = 102)
                )
                SELECT MMashatId, sum(monymonth) AS monymonth,
                (SELECT SyndicateId FROM TBLMashat WHERE MMashatId = XXX.MMashatId) AS SyndicateId,
                (SELECT SubCommitteId FROM TBLMashat WHERE MMashatId = XXX.MMashatId) AS SubCommitteId,
                (SELECT sarfnumber FROM TBLMashat WHERE MMashatId = XXX.MMashatId) AS sarfnumber
                FROM XXX
                GROUP BY MMashatId HAVING sum(monymonth) = 0";
            }
        }
        public static string vQry14
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry14]
                AS
                SELECT PersonId, MMashatId, WarasaTypeId, personName, personNID, yasref, datein, SyndicateId,
                (SELECT RealName FROM Users WHERE UserID = TBLWarasa.userin) as RealName,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLWarasa.SyndicateId) as SyndicateW,
                (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLWarasa.SubCommitteId) as SubCommitteW,
                (SELECT MMashatName FROM TBLMashat WHERE MMashatId = TBLWarasa.MMashatId) as MMashatName,
                (SELECT sarfnumber FROM TBLMashat WHERE MMashatId = TBLWarasa.MMashatId) as sarfnumber,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = (SELECT SyndicateId FROM TBLMashat as tblsM WHERE MMashatId = TBLWarasa.MMashatId)) as SyndicateR,
                (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = (SELECT SyndicateId FROM TBLMashat as tblsM WHERE MMashatId = TBLWarasa.MMashatId)) as SubCommitteR
                FROM TBLWarasa WHERE personName is null or personName = ''";
            }
        }
        public static string vQry15
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry15]
                AS
                SELECT TBLWarasa.PersonId, TBLWarasa.WarasaTypeId, TBLWarasa.personName, TBLWarasa.SyndicateId, TBLWarasa.SubCommitteId, TBLMashat.sarfnumber, 
                CDSyndicate.Syndicate, CDSubCommitte.SubCommitte, TBLMashat.MMashatName
                FROM TBLWarasa LEFT OUTER JOIN
                CDSubCommitte ON TBLWarasa.SubCommitteId = CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                CDSyndicate ON TBLWarasa.SyndicateId = CDSyndicate.SyndicateId LEFT OUTER JOIN
                TBLMashat ON TBLWarasa.MMashatId = TBLMashat.MMashatId
                WHERE (NOT EXISTS (SELECT SubCommitteId, SubCommitte, SyndicateId FROM CDSubCommitte AS CDSubCommitte_1
                WHERE (SyndicateId = TBLWarasa.SyndicateId) AND (SubCommitteId = TBLWarasa.SubCommitteId)))";
            }
        }
        public static string vQry19
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry19]
                AS
                SELECT MMashatId, MMashatName, SyndicateId, SubCommitteId, sarfnumber,
                (SELECT TOP 1 datehala FROM TBLNoSarfDetels WHERE MMashatId = TBLMashat.MMashatId AND yasref = TBLMashat.yasref order by datein desc) AS datehala,
                (SELECT TOP 1 halarem FROM TBLNoSarfDetels WHERE MMashatId = TBLMashat.MMashatId AND yasref = TBLMashat.yasref order by datein desc) AS halarem
                FROM TBLMashat
                WHERE (MashHalaId = 1) AND (yasref = 0) ";
            }
        }
        public static string vQry20
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry20]
                AS
                SELECT PersonId, personName, SyndicateId, SubCommitteId,
                (SELECT sarfnumber FROM TBLMashat WHERE MMashatId = TBLWarasa.MMashatId) AS sarfnumber,
                (SELECT TOP 1 datehala FROM TBLNoSarfWarsa WHERE PersonId = TBLWarasa.PersonId AND yasref = TBLWarasa.yasref order by datein desc) AS datehala,
                (SELECT TOP 1 halarem FROM TBLNoSarfWarsa WHERE PersonId = TBLWarasa.MMashatId AND yasref = TBLWarasa.yasref order by datein desc) AS halarem
                FROM TBLWarasa
                WHERE (yasref = 0)";
            }
        }
        public static string vTBLMashat01_V1
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLMashat01_V1]
                AS
                select MMashatId, MMashatName, sarfnumber, 
                (select Syndicate from CDSyndicate where SyndicateId = TBLMashat.SyndicateId) as Syndicate,
                (select SubCommitte from CDSubCommitte where SubCommitteId = TBLMashat.SubCommitteId) as SubCommitte
                from TBLMashat";
            }
        }
        public static string vTBLMashat01_V2
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLMashat01_V2]
                AS
                SELECT MMashatId, DofatSarfId, 
                (select MMashatName from TBLMashat where MMashatId = TBLMemberSarf.MMashatId) as MMashatName,
                (select sarfnumber from TBLMashat where MMashatId = TBLMemberSarf.MMashatId) as sarfnumber,
                (select Syndicate from CDSyndicate where SyndicateId = (select SyndicateId from TBLMashat where MMashatId = TBLMemberSarf.MMashatId)) as Syndicate,
                (select SubCommitte from CDSubCommitte where SubCommitteId = (select SubCommitteId from TBLMashat where MMashatId = TBLMemberSarf.MMashatId)) as SubCommitte
                FROM TBLMemberSarf
                WHERE sarf = 0
                GROUP BY MMashatId, DofatSarfId";
            }
        }
        public static string vQry22
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry22]
                AS
                SELECT        dbo.TblMemberAmanat.MMashatId, dbo.TblMemberAmanat.DofatSarfAId, dbo.TblMemberAmanat.amanatmony, dbo.TblMemberAmanat.amanatrem, 
                dbo.TblMemberAmanat.userin, dbo.TblMemberAmanat.datein, dbo.TBLMashat.MMashatName, dbo.TBLMashat.sarfnumber, dbo.CDSyndicate.Syndicate, 
                dbo.CDSubCommitte.SubCommitte, dbo.Users.RealName, dbo.CdDofaatAmanat.DofatSarfA, dbo.CdDofaatAmanat.DofatSarfDatefrom, 
                dbo.CdDofaatAmanat.DofatSarfDateto
                FROM            dbo.CdDofaatAmanat RIGHT OUTER JOIN
                dbo.TblMemberAmanat ON dbo.CdDofaatAmanat.DofatSarfAId = dbo.TblMemberAmanat.DofatSarfAId LEFT OUTER JOIN
                dbo.Users RIGHT OUTER JOIN
                dbo.TBLMashat ON dbo.Users.UserID = dbo.TBLMashat.userin LEFT OUTER JOIN
                dbo.CDSubCommitte ON dbo.TBLMashat.SubCommitteId = dbo.CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                dbo.CDSyndicate ON dbo.TBLMashat.SyndicateId = dbo.CDSyndicate.SyndicateId ON dbo.TblMemberAmanat.MMashatId = dbo.TBLMashat.MMashatId";
            }
        }
        public static string vQry23
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry23]
                AS
                SELECT        dbo.TblWarasaAmanat.PersonId, dbo.TblWarasaAmanat.DofatSarfAId, dbo.TblWarasaAmanat.amanatmony, dbo.TblWarasaAmanat.amanatrem, 
                dbo.TblWarasaAmanat.userin, dbo.TblWarasaAmanat.datein, dbo.CdDofaatAmanat.DofatSarfA, dbo.CdDofaatAmanat.DofatSarfDatefrom, 
                dbo.CdDofaatAmanat.DofatSarfDateto, dbo.TBLWarasa.personName, dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte, 
                dbo.TBLMashat.MMashatName, dbo.TBLMashat.sarfnumber, dbo.Users.RealName
                FROM            dbo.TBLMashat INNER JOIN
                dbo.TBLWarasa ON dbo.TBLMashat.MMashatId = dbo.TBLWarasa.MMashatId LEFT OUTER JOIN
                dbo.CDSyndicate ON dbo.TBLWarasa.SyndicateId = dbo.CDSyndicate.SyndicateId LEFT OUTER JOIN
                dbo.CDSubCommitte ON dbo.TBLWarasa.SubCommitteId = dbo.CDSubCommitte.SubCommitteId RIGHT OUTER JOIN
                dbo.TblWarasaAmanat ON dbo.TBLWarasa.PersonId = dbo.TblWarasaAmanat.PersonId LEFT OUTER JOIN
                dbo.CdDofaatAmanat ON dbo.TblWarasaAmanat.DofatSarfAId = dbo.CdDofaatAmanat.DofatSarfAId LEFT OUTER JOIN
                dbo.Users ON dbo.TblWarasaAmanat.userin = dbo.Users.UserID";
            }
        }
        public static string vQry25
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry25]
                AS
                SELECT        MMashatId, MMashatName, MMashatNId, sarfnumber, SyndicateId, SubCommitteId
                FROM            dbo.TBLMashat
                WHERE        (MMashatNId IS NOT NULL) AND (MMashatNId <> '') AND (LEN(MMashatNId) <> 14)";
            }
        }
        public static string vQry26
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry26]
                AS
                SELECT        PersonId, personName, personNID, SyndicateId, SubCommitteId
                FROM            dbo.TBLWarasa
                WHERE        (personNID IS NOT NULL) AND (personNID <> '') AND (LEN(personNID) <> 14)";
            }
        }
        public static string vQry27
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry27]
                AS
                SELECT        dbo.TBLMemberSarf_arshef.MMashatId, dbo.TBLMemberSarf_arshef.DofatSarfId, dbo.TBLMemberSarf_arshef.SarfTypeedadId, dbo.TBLMemberSarf_arshef.sarfdatefrom, dbo.TBLMemberSarf_arshef.sarfdateto, 
                         dbo.TBLMemberSarf_arshef.monymonth, dbo.TBLMemberSarf_arshef.rsmmonth, dbo.TBLMemberSarf_arshef.eshtrakmonth, dbo.TBLMemberSarf_arshef.estktaa, dbo.TBLMemberSarf_arshef.sarf, 
                         dbo.TBLMemberSarf_arshef.datein, dbo.TBLMemberSarf_arshef.userin, dbo.TBLMemberSarf_arshef.Edafat, dbo.TBLMemberSarf_arshef.SyndicateId, dbo.TBLMemberSarf_arshef.SubCommitteId, 
                         dbo.TBLMashat.MMashatName, dbo.TBLMashat.sarfnumber, dbo.TBLDofatSarf.DofatSarf, dbo.CDSarfTypeedad.SarfTypeedad, dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte, 
                         dbo.TBLMashat.yasref AS Current_Yasref
FROM            dbo.TBLMemberSarf_arshef LEFT OUTER JOIN
                         dbo.CDSarfTypeedad ON dbo.TBLMemberSarf_arshef.SarfTypeedadId = dbo.CDSarfTypeedad.SarfTypeedadId LEFT OUTER JOIN
                         dbo.TBLDofatSarf ON dbo.TBLMemberSarf_arshef.DofatSarfId = dbo.TBLDofatSarf.DofatSarfId LEFT OUTER JOIN
                         dbo.CDSubCommitte ON dbo.TBLMemberSarf_arshef.SubCommitteId = dbo.CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                         dbo.CDSyndicate ON dbo.TBLMemberSarf_arshef.SyndicateId = dbo.CDSyndicate.SyndicateId LEFT OUTER JOIN
                         dbo.TBLMashat ON dbo.TBLMemberSarf_arshef.MMashatId = dbo.TBLMashat.MMashatId";
            }
        }
        public static string vQry28
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry28]
                AS
                SELECT        dbo.TBLWarasaSarf_arshef.PersonId, dbo.TBLWarasaSarf_arshef.DofatSarfId, dbo.TBLWarasaSarf_arshef.SarfTypeedadId, dbo.TBLWarasaSarf_arshef.sarfdatefrom, dbo.TBLWarasaSarf_arshef.sarfdateto, 
                         dbo.TBLWarasaSarf_arshef.monymonth, dbo.TBLWarasaSarf_arshef.rsmmonth, dbo.TBLWarasaSarf_arshef.eshtrakmonth, dbo.TBLWarasaSarf_arshef.estktaa, dbo.TBLWarasaSarf_arshef.sarf, 
                         dbo.TBLWarasaSarf_arshef.datein, dbo.TBLWarasaSarf_arshef.userin, dbo.TBLWarasaSarf_arshef.Edafat, dbo.TBLWarasaSarf_arshef.SyndicateId, dbo.TBLWarasaSarf_arshef.SubCommitteId, 
                         dbo.TBLDofatSarf.DofatSarf, dbo.CDSarfTypeedad.SarfTypeedad, TBLWarasa_1.personName, dbo.TBLMashat.MMashatName, dbo.TBLMashat.sarfnumber, TBLWarasa_1.MMashatId, 
                         dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte, dbo.TBLWarasaSarf_arshef.responsiblesarf, dbo.TBLWarasaSarf_arshef.responsiblesarfId, 
                         dbo.TBLWarasa.personName AS ResponsiblesarfName, TBLWarasa_1.yasref AS Yasref_Current
FROM            dbo.TBLWarasa RIGHT OUTER JOIN
                         dbo.TBLWarasaSarf_arshef ON dbo.TBLWarasa.PersonId = dbo.TBLWarasaSarf_arshef.responsiblesarfId LEFT OUTER JOIN
                         dbo.TBLMashat RIGHT OUTER JOIN
                         dbo.TBLWarasa AS TBLWarasa_1 ON dbo.TBLMashat.MMashatId = TBLWarasa_1.MMashatId ON dbo.TBLWarasaSarf_arshef.PersonId = TBLWarasa_1.PersonId LEFT OUTER JOIN
                         dbo.CDSarfTypeedad ON dbo.TBLWarasaSarf_arshef.SarfTypeedadId = dbo.CDSarfTypeedad.SarfTypeedadId LEFT OUTER JOIN
                         dbo.TBLDofatSarf ON dbo.TBLWarasaSarf_arshef.DofatSarfId = dbo.TBLDofatSarf.DofatSarfId LEFT OUTER JOIN
                         dbo.CDSubCommitte ON dbo.TBLWarasaSarf_arshef.SubCommitteId = dbo.CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                         dbo.CDSyndicate ON dbo.TBLWarasaSarf_arshef.SyndicateId = dbo.CDSyndicate.SyndicateId";
            }
        }
        public static string vQry31
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry31]
                AS
                SELECT        COUNT(dbo.TBLMashat.MMashatId) AS CountMMashatId, dbo.TBLMashat.yasref, dbo.TBLMashat.SarfExpetion, dbo.TBLMashat.mcompletesarf, dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte, 
                         dbo.CDMashHala.MashHala
                FROM            dbo.TBLMashat LEFT OUTER JOIN
                         dbo.CDMashHala ON dbo.TBLMashat.MashHalaId = dbo.CDMashHala.MashHalaId LEFT OUTER JOIN
                         dbo.CDSubCommitte ON dbo.TBLMashat.SubCommitteId = dbo.CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                         dbo.CDSyndicate ON dbo.TBLMashat.SyndicateId = dbo.CDSyndicate.SyndicateId
                GROUP BY dbo.TBLMashat.yasref, dbo.TBLMashat.SarfExpetion, dbo.TBLMashat.mcompletesarf, dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte, dbo.CDMashHala.MashHala";
            }
        }
        public static string vQry32
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry32]
                AS
                SELECT        COUNT(dbo.TBLWarasa.PersonId) AS CountPersonId, dbo.CDWarasaType.WarasaType, dbo.TBLWarasa.yasref, dbo.TBLWarasa.responsiblesarf, dbo.CDSyndicate.Syndicate, 
                         dbo.CDSubCommitte.SubCommitte
                FROM            dbo.CDSyndicate RIGHT OUTER JOIN
                         dbo.TBLWarasa ON dbo.CDSyndicate.SyndicateId = dbo.TBLWarasa.SyndicateId LEFT OUTER JOIN
                         dbo.CDSubCommitte ON dbo.TBLWarasa.SubCommitteId = dbo.CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                         dbo.CDWarasaType ON dbo.TBLWarasa.WarasaTypeId = dbo.CDWarasaType.WarasaTypeId
                GROUP BY dbo.CDWarasaType.WarasaType, dbo.TBLWarasa.yasref, dbo.TBLWarasa.responsiblesarf, dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte";
            }
        }
        public static string vQry33
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry33]
                AS
                SELECT        dbo.TBLMashat.MMashatId, dbo.TBLMashat.MMashatName, dbo.TBLMashat.KideNumber, dbo.TBLMashat.sarfnumber, dbo.TBLMashat.MMashatNId, dbo.TBLDofatSarf.DofatSarfId, dbo.TBLDofatSarf.DofatSarf, 
                         dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte, SUM(dbo.TBLMemberSarf.monymonth - dbo.TBLMemberSarf.rsmmonth - dbo.TBLMemberSarf.eshtrakmonth - dbo.TBLMemberSarf.estktaa) 
                         AS VAL
                FROM            dbo.TBLDofatSarf RIGHT OUTER JOIN
                         dbo.TBLMemberSarf LEFT OUTER JOIN
                         dbo.CDSubCommitte ON dbo.TBLMemberSarf.SubCommitteId = dbo.CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                         dbo.CDSyndicate ON dbo.TBLMemberSarf.SyndicateId = dbo.CDSyndicate.SyndicateId ON dbo.TBLDofatSarf.DofatSarfId = dbo.TBLMemberSarf.DofatSarfId LEFT OUTER JOIN
                         dbo.TBLMashat ON dbo.TBLMemberSarf.MMashatId = dbo.TBLMashat.MMashatId
                WHERE        (dbo.TBLMemberSarf.sarf = 1)
                GROUP BY dbo.TBLMashat.MMashatId, dbo.TBLMashat.MMashatName, dbo.TBLMashat.KideNumber, dbo.TBLMashat.sarfnumber, dbo.TBLMashat.MMashatNId, dbo.TBLDofatSarf.DofatSarfId, dbo.TBLDofatSarf.DofatSarf, 
                         dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte";
            }
        }
        public static string vQry34_Replaced //Cus its slow
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry34]
                AS
                WITH CTE
                AS
                (
                SELECT PersonId, 
                (SELECT WarasaType FROM CDWarasaType WHERE WarasaTypeId = (SELECT WarasaTypeId FROM TBLWarasa WHERE PersonId = TBLWarasaSarf.PersonId)) AS WarasaType,
				(SELECT DofatSarf FROM TBLDofatSarf WHERE DofatSarfId = TBLWarasaSarf.DofatSarfId) AS DofatSarf,
                (SELECT MMashatId FROM TBLWarasa WHERE PersonId = TBLWarasaSarf.PersonId) AS MMashatId,
                (SELECT personName FROM TBLWarasa WHERE PersonId = TBLWarasaSarf.PersonId) AS personName,
                (SELECT personNID FROM TBLWarasa WHERE PersonId = TBLWarasaSarf.PersonId) AS personNID,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = (SELECT SyndicateId FROM TBLWarasa WHERE PersonId = TBLWarasaSarf.PersonId)) AS Syndicate,
                (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = (SELECT SubCommitteId FROM TBLWarasa WHERE PersonId = TBLWarasaSarf.PersonId)) AS SubCommitte,
                (SELECT MMashatName FROM TBLMashat WHERE MMashatId = (SELECT MMashatId FROM TBLWarasa WHERE PersonId = TBLWarasaSarf.PersonId)) AS MMashatName,
                (SELECT sarfnumber FROM TBLMashat WHERE MMashatId = (SELECT MMashatId FROM TBLWarasa WHERE PersonId = TBLWarasaSarf.PersonId)) AS sarfnumber,
                (SELECT ISNULL(SUM(monymonth), 0) FROM TBLWarasaSarf AS tblw WHERE  Edafat = TBLWarasaSarf.Edafat AND DofatSarfId = TBLWarasaSarf.DofatSarfId AND
                exists(select PersonId FROM TBLWarasa WHERE PersonId = tblw.PersonId AND responsiblesarfId = TBLWarasaSarf.PersonId)) as monymonth,
                (SELECT ISNULL(SUM(rsmmonth), 0) FROM TBLWarasaSarf AS tblw WHERE   Edafat = TBLWarasaSarf.Edafat AND DofatSarfId = TBLWarasaSarf.DofatSarfId AND
                exists(select PersonId FROM TBLWarasa WHERE PersonId = tblw.PersonId AND responsiblesarfId = TBLWarasaSarf.PersonId)) as rsmmonth,
                (SELECT ISNULL(SUM(eshtrakmonth), 0) FROM TBLWarasaSarf AS tblw WHERE   Edafat = TBLWarasaSarf.Edafat AND DofatSarfId = TBLWarasaSarf.DofatSarfId AND
                exists(select PersonId FROM TBLWarasa WHERE PersonId = tblw.PersonId AND responsiblesarfId = TBLWarasaSarf.PersonId)) as eshtrakmonth,
                (SELECT ISNULL(SUM(estktaa), 0) FROM TBLWarasaSarf AS tblw WHERE   Edafat = TBLWarasaSarf.Edafat AND DofatSarfId = TBLWarasaSarf.DofatSarfId AND
                exists(select PersonId FROM TBLWarasa WHERE PersonId = tblw.PersonId AND responsiblesarfId = TBLWarasaSarf.PersonId)) as estktaa
                FROM TBLWarasaSarf
                )
                SELECT PersonId, WarasaType, DofatSarf, MMashatId, personName, personNID, Syndicate, SubCommitte, MMashatName, sarfnumber, 
                SUM(monymonth - rsmmonth - eshtrakmonth - estktaa) AS VAL FROM CTE
                GROUP BY PersonId, WarasaType, DofatSarf, MMashatId, personName, personNID, Syndicate, SubCommitte, MMashatName, sarfnumber";
            }
        }
        public static string vQry35
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry35]
                AS
                SELECT PersonId, MMashatId, WarasaTypeId, personName, personNID, yasref, datein, SyndicateId,
                (SELECT RealName FROM dbo.Users WHERE        (UserID = dbo.TBLWarasa.userin)) AS RealName,
                (SELECT Syndicate FROM dbo.CDSyndicate WHERE        (SyndicateId = dbo.TBLWarasa.SyndicateId)) AS SyndicateW,
                (SELECT SubCommitte FROM dbo.CDSubCommitte WHERE        (SubCommitteId = dbo.TBLWarasa.SubCommitteId)) AS SubCommitteW,
                (SELECT MMashatName FROM dbo.TBLMashat WHERE        (MMashatId = dbo.TBLWarasa.MMashatId)) AS MMashatName,
                (SELECT sarfnumber FROM dbo.TBLMashat AS TBLMashat_1 WHERE        (MMashatId = dbo.TBLWarasa.MMashatId)) AS sarfnumber,
                (SELECT personName FROM dbo.TBLWarasa AS TBLWS WHERE        (PersonId = dbo.TBLWarasa.responsiblesarfId)) AS personNameR
                FROM dbo.TBLWarasa
                WHERE (yasref = 1) AND (responsiblesarf = 0) AND (responsiblesarfId <> PersonId) 
                AND EXISTS (SELECT PersonId FROM dbo.TBLWarasa AS TBL WHERE (PersonId = dbo.TBLWarasa.responsiblesarfId) AND (yasref = 0))";
            }
        }
        public static string vQry42
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry42]
                    AS
                    SELECT        dbo.TBLWarasaSarf.PersonId, dbo.TBLWarasaSarf.DofatSarfId, dbo.TBLWarasaSarf.SarfTypeedadId, dbo.TBLWarasaSarf.sarfdatefrom, dbo.TBLWarasaSarf.sarfdateto, dbo.TBLWarasaSarf.monymonth, 
                                             dbo.TBLWarasaSarf.rsmmonth, dbo.TBLWarasaSarf.eshtrakmonth, dbo.TBLWarasaSarf.estktaa, dbo.TBLWarasaSarf.sarf, dbo.TBLWarasaSarf.datein, dbo.TBLWarasaSarf.userin, dbo.TBLWarasaSarf.Edafat, 
                                             dbo.TBLWarasaSarf.SyndicateId, dbo.TBLWarasaSarf.SubCommitteId, dbo.TBLWarasa.personName, dbo.TBLWarasa.yasref, dbo.TBLMashat.MMashatName, dbo.TBLMashat.sarfnumber, 
                                             dbo.CDSyndicate.Syndicate, dbo.Users.RealName, dbo.TBLDofatSarf.DofatSarf, dbo.CDSubCommitte.SubCommitte
                    FROM            dbo.TBLWarasaSarf INNER JOIN
                                             dbo.TBLWarasa ON dbo.TBLWarasaSarf.PersonId = dbo.TBLWarasa.PersonId INNER JOIN
                                             dbo.TBLDofatSarf ON dbo.TBLWarasaSarf.DofatSarfId = dbo.TBLDofatSarf.DofatSarfId INNER JOIN
                                             dbo.CDSyndicate ON dbo.TBLWarasaSarf.SyndicateId = dbo.CDSyndicate.SyndicateId INNER JOIN
                                             dbo.Users ON dbo.TBLWarasaSarf.userin = dbo.Users.UserID INNER JOIN
                                             dbo.CDSubCommitte ON dbo.TBLWarasaSarf.SubCommitteId = dbo.CDSubCommitte.SubCommitteId INNER JOIN
                                             dbo.TBLMashat ON dbo.TBLWarasa.MMashatId = dbo.TBLMashat.MMashatId";
            }
        }
        public static string vQry43
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry43]
                    AS
                                    SELECT        TBLMemberSarf.MMashatId, TBLMemberSarf.DofatSarfId, TBLMemberSarf.SarfTypeedadId, TBLMemberSarf.sarfdatefrom, TBLMemberSarf.sarfdateto, TBLMemberSarf.monymonth, TBLMemberSarf.rsmmonth, 
                         TBLMemberSarf.eshtrakmonth, TBLMemberSarf.estktaa, TBLMemberSarf.sarf, TBLMemberSarf.datein, TBLMemberSarf.userin, TBLMemberSarf.Edafat, TBLMemberSarf.SyndicateId, 
                         TBLMemberSarf.SubCommitteId, Users.RealName, CDSyndicate.Syndicate, CDSubCommitte.SubCommitte, TBLMashat.MMashatName, TBLMashat.sarfnumber, TBLDofatSarf.DofatSarf
FROM            TBLMemberSarf INNER JOIN
                         TBLMashat ON TBLMemberSarf.MMashatId = TBLMashat.MMashatId INNER JOIN
                         CDSubCommitte ON TBLMashat.SubCommitteId = CDSubCommitte.SubCommitteId INNER JOIN
                         CDSyndicate ON CDSubCommitte.SyndicateId = CDSyndicate.SyndicateId INNER JOIN
                         Users ON TBLMashat.userin = Users.UserID INNER JOIN
                         TBLDofatSarf ON TBLMemberSarf.DofatSarfId = TBLDofatSarf.DofatSarfId";
            }
        }
        public static string TBLProofDoc
        {
            get
            {
                return @"
                        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLProofDoc]') AND type in (N'U'))
                        BEGIN
                        CREATE TABLE [dbo].[TBLProofDoc](
	                        [ProofDocId] [int] NOT NULL,
	                        [MMashatId] [int] NULL,
	                        [DocDate] [date] NULL,
	                        [userin] [int] NULL,
	                        [datein] [datetime] NULL,
	                        [memo] [nvarchar](255) NULL,
                         CONSTRAINT [PK_ProofDoc] PRIMARY KEY CLUSTERED 
                        (
	                        [ProofDocId] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                        ) ON [PRIMARY]
                        END";
            }
        }
        public static string BankExportedData
        {
            get
            {
                return @"
                        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BankExportedData]') AND type in (N'U'))
                        BEGIN
                        CREATE TABLE [dbo].[BankExportedData](
	                        [Id] [int] IDENTITY(1,1) NOT NULL,
	                        [MMashatId] [int] NULL,
	                        [ExportDate] [date] NULL,
	                        [userin] [int] NULL,
                         CONSTRAINT [PK_BankExportedData] PRIMARY KEY CLUSTERED 
                        (
	                        [Id] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                        ) ON [PRIMARY]
                        END";
            }
        }
        public static string vQry57
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry57]
                    AS
                                    SELECT        BankExportedData.Id, BankExportedData.MMashatId, BankExportedData.ExportDate, BankExportedData.hafza, BankExportedData.hafzadate, TBLMashat.MMashatName, TBLMashat.MMashatNId, 
                    TBLMashat.sarfnumber, CDSyndicate.Syndicate, CDSubCommitte.SubCommitte, BankExportedData.Activate, BankExportedData.ActivateDate
                    FROM            BankExportedData INNER JOIN
                    TBLMashat ON BankExportedData.MMashatId = TBLMashat.MMashatId INNER JOIN
                    CDSyndicate ON TBLMashat.SyndicateId = CDSyndicate.SyndicateId INNER JOIN
                    CDSubCommitte ON TBLMashat.SubCommitteId = CDSubCommitte.SubCommitteId";
            }
        }
        public static string vQry58
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry58]
                    AS
                                    SELECT        BankExportedDataWarsa.Id, BankExportedDataWarsa.ExportDate, BankExportedDataWarsa.PersonId, BankExportedDataWarsa.hafza, BankExportedDataWarsa.hafzadate, TBLWarasa.personName, 
                         TBLWarasa.personNID, TBLMashat.sarfnumber, CDSubCommitte.SubCommitte, CDSyndicate.Syndicate, BankExportedDataWarsa.Activate, BankExportedDataWarsa.ActivateDate
                FROM            CDSubCommitte INNER JOIN
                         CDSyndicate INNER JOIN
                         TBLWarasa INNER JOIN
                         BankExportedDataWarsa ON TBLWarasa.PersonId = BankExportedDataWarsa.PersonId ON CDSyndicate.SyndicateId = TBLWarasa.SyndicateId ON 
                         CDSubCommitte.SubCommitteId = TBLWarasa.SubCommitteId INNER JOIN
                         TBLMashat ON BankExportedDataWarsa.MMashatId = TBLMashat.MMashatId
";
            }
        }
        public static string vQry59
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry59]
                    AS
                                    SELECT        CAST(TBLBeanWarsa.PersonId AS VARCHAR) + CAST(TBLBeanWarsa.DofatSarfId AS VARCHAR) AS autoId, TBLBeanWarsa.PersonId, TBLBeanWarsa.DofatSarfId, TBLBeanWarsa.Beandate, 
                         TBLBeanWarsa.deleted, TBLBeanWarsa.remarks, TBLBeanWarsa.dateremember, TBLBeanWarsa.userin, TBLBeanWarsa.datein, TBLDofatSarf.DofatSarf, CDSyndicate.Syndicate, CDSubCommitte.SubCommitte, 
                         TBLMashat.MMashatName, TBLMashat.sarfnumber, TBLWarasa.personNID, TBLWarasa.personName
                FROM            TBLBeanWarsa INNER JOIN
                         TBLWarasa ON TBLBeanWarsa.PersonId = TBLWarasa.PersonId INNER JOIN
                         TBLDofatSarf ON TBLBeanWarsa.DofatSarfId = TBLDofatSarf.DofatSarfId INNER JOIN
                         TBLMashat ON TBLWarasa.MMashatId = TBLMashat.MMashatId INNER JOIN
                         CDSyndicate ON TBLWarasa.SyndicateId = CDSyndicate.SyndicateId INNER JOIN
                         CDSubCommitte ON TBLWarasa.SubCommitteId = CDSubCommitte.SubCommitteId
";
            }
        }
        public static string vQry71
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry71]
                    AS
                                    WITH CTE1 AS
(
SELECT 
CAST(TBLWarasa.MMashatId AS VARCHAR) + '-' + CAST(TBLWarasaSarf_arshef.DofatSarfId AS VARCHAR) AS AutoId
, TBLWarasa.MMashatId, SUM(monymonth - rsmmonth - TBLWarasaSarf_arshef.eshtrakmonth - estktaa) AS Total, TBLDofatSarf.DofatSarf, TBLWarasaSarf_arshef.DofatSarfId, TBLMashat.MMashatName, TBLMashat.sarfnumber, CDSyndicate.Syndicate, 
CDSubCommitte.SubCommitte
, ISNULL((SELECT SUM(summony) FROM [dbo].[tblWarasabank] WHERE [MMashatId] = TBLWarasa.MMashatId AND [DofatSarfId] = TBLWarasaSarf_arshef.DofatSarfId), 0) BankMoney
FROM            TBLWarasaSarf_arshef INNER JOIN
TBLWarasa ON TBLWarasaSarf_arshef.PersonId = TBLWarasa.PersonId INNER JOIN
TBLDofatSarf ON TBLWarasaSarf_arshef.DofatSarfId = TBLDofatSarf.DofatSarfId INNER JOIN
TBLMashat ON TBLWarasa.MMashatId = TBLMashat.MMashatId INNER JOIN
CDSubCommitte ON TBLMashat.SubCommitteId = CDSubCommitte.SubCommitteId INNER JOIN
CDSyndicate ON TBLMashat.SyndicateId = CDSyndicate.SyndicateId
GROUP BY TBLWarasa.MMashatId, TBLDofatSarf.DofatSarf, TBLWarasaSarf_arshef.DofatSarfId, TBLMashat.MMashatName, TBLMashat.sarfnumber, CDSyndicate.Syndicate, CDSubCommitte.SubCommitte
)
SELECT *,
Total - BankMoney AS DiffMoney
 FROM CTE1
WHERE Total <> BankMoney
";
            }
        }
        public static string vTBLDeathMembers
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLDeathMembers]
                    AS
                                    SELECT        TBLDeathMembers.MMashatId, TBLDeathMembers.deathdate, TBLDeathMembers.mosthhek, TBLDeathMembers.datein, TBLDeathMembers.userin, TBLMashat.MMashatName, TBLMashat.SyndicateId, 
                         TBLMashat.SubCommitteId, TBLMashat.sarfnumber, CDSyndicate.Syndicate, CDSubCommitte.SubCommitte, TBLMashat.yasref, Users.RealName
                FROM            TBLDeathMembers INNER JOIN
                         TBLMashat ON TBLDeathMembers.MMashatId = TBLMashat.MMashatId INNER JOIN
                         CDSyndicate ON TBLMashat.SyndicateId = CDSyndicate.SyndicateId INNER JOIN
                         CDSubCommitte ON TBLMashat.SubCommitteId = CDSubCommitte.SubCommitteId INNER JOIN
                         Users ON TBLDeathMembers.userin = Users.UserID";
            }
        }
        public static string vQry73
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry73]
                    AS
                    WITH CTE1 AS 
                    (SELECT        dbo.TBLNoSarfWarsa.PersonId, MAX(dbo.TBLNoSarfWarsa.datehala) AS datehala, dbo.TBLWarasa.personName, dbo.CDSyndicate.Syndicate, dbo.CDWarasaType.WarasaType, 
                    dbo.CDSubCommitte.SubCommitte, dbo.TBLMashat.MMashatId, dbo.TBLMashat.MMashatName, dbo.TBLMashat.sarfnumber
                    , TBLWarasa.SyndicateId, TBLWarasa.SubCommitteId
                    FROM dbo.TBLNoSarfWarsa INNER JOIN
                    dbo.TBLWarasa ON dbo.TBLNoSarfWarsa.PersonId = dbo.TBLWarasa.PersonId INNER JOIN
                    dbo.CDSyndicate ON dbo.TBLWarasa.SyndicateId = dbo.CDSyndicate.SyndicateId INNER JOIN
                    dbo.CDWarasaType ON dbo.TBLWarasa.WarasaTypeId = dbo.CDWarasaType.WarasaTypeId INNER JOIN
                    dbo.CDSubCommitte ON dbo.TBLWarasa.SubCommitteId = dbo.CDSubCommitte.SubCommitteId INNER JOIN
                    dbo.TBLMashat ON dbo.TBLWarasa.MMashatId = dbo.TBLMashat.MMashatId
                    WHERE        (dbo.TBLNoSarfWarsa.yasref = 0) AND (dbo.TBLWarasa.yasref = 0)
                    GROUP BY dbo.TBLNoSarfWarsa.PersonId, dbo.TBLWarasa.personName, dbo.CDSyndicate.Syndicate, dbo.CDWarasaType.WarasaType, dbo.CDSubCommitte.SubCommitte, dbo.TBLMashat.MMashatId, 
                    dbo.TBLMashat.MMashatName, dbo.TBLMashat.sarfnumber, TBLWarasa.SyndicateId, TBLWarasa.SubCommitteId
                    )
                    SELECT PersonId, datehala, personName, Syndicate, WarasaType, SubCommitte, MMashatId, MMashatName, sarfnumber
                    , SyndicateId, SubCommitteId
                    ,(SELECT TOP (1) halarem FROM dbo.TBLNoSarfWarsa AS TBL WHERE (PersonId = CTE1_1.PersonId) AND (yasref = 0) AND (datehala = CTE1_1.datehala)) AS halarem
                    FROM CTE1 AS CTE1_1";
            }
        }
        public static string vtbladminremarks
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vtbladminremarks]
                    AS
                    SELECT        tbladminremarks.remarkid, tbladminremarks.MMashatId, tbladminremarks.mremark, tbladminremarks.datein, tbladminremarks.userin, tbladminremarks.adminremark, tbladminremarks.admindatein, 
                         tbladminremarks.finished, Users.RealName, TBLMashat.MMashatName, TBLMashat.SyndicateId, TBLMashat.SubCommitteId, TBLMashat.sarfnumber, CDSubCommitte.SubCommitte, 
                         CDSyndicate.Syndicate
                FROM            tbladminremarks INNER JOIN
                         TBLMashat ON tbladminremarks.MMashatId = TBLMashat.MMashatId INNER JOIN
                         CDSyndicate ON TBLMashat.SyndicateId = CDSyndicate.SyndicateId INNER JOIN
                         CDSubCommitte ON TBLMashat.SubCommitteId = CDSubCommitte.SubCommitteId INNER JOIN
                         Users ON tbladminremarks.userin = Users.UserID";
            }
        }
        public static string vQry74
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry74]
                    AS
                    SELECT        TBLReSarfWarasa.PersonId, TBLReSarfWarasa.DofatSarfId, TBLReSarfWarasa.datefrom, TBLReSarfWarasa.dateto, TBLReSarfWarasa.reestktaa, TBLReSarfWarasa.remarks, TBLDofatSarf.DofatSarf, 
                         TBLWarasa.personName, TBLWarasa.personNID, TBLWarasa.yasref, TBLWarasa.MMashatId, CDSubCommitte.SubCommitte, CDSyndicate.Syndicate, CDWarasaType.WarasaType, TBLMashat.MMashatName, 
                         TBLMashat.sarfnumber
                    FROM            TBLReSarfWarasa INNER JOIN
                         TBLWarasa ON TBLReSarfWarasa.PersonId = TBLWarasa.PersonId INNER JOIN
                         CDSyndicate ON TBLWarasa.SyndicateId = CDSyndicate.SyndicateId INNER JOIN
                         TBLDofatSarf ON TBLReSarfWarasa.DofatSarfId = TBLDofatSarf.DofatSarfId INNER JOIN
                         CDSubCommitte ON TBLWarasa.SubCommitteId = CDSubCommitte.SubCommitteId INNER JOIN
                         TBLMashat ON TBLWarasa.MMashatId = TBLMashat.MMashatId INNER JOIN
                         CDWarasaType ON TBLWarasa.WarasaTypeId = CDWarasaType.WarasaTypeId";
            }
        }
        public static string vQry75
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry75]
                    AS
                    SELECT        TBLWarasa.PersonId, TBLWarasa.personName, TBLWarasa.yasref, TBLWarasa.SyndicateId, TBLWarasa.SubCommitteId, CDSyndicate.Syndicate, CDSubCommitte.SubCommitte, TBLBeanWarsa.DofatSarfId, 
                         TBLBeanWarsa.Beandate, TBLBeanWarsa.deleted, TBLBeanWarsa.remarks, TBLBeanWarsa.dateremember, TBLDofatSarf.DofatSarf
FROM            TBLBeanWarsa INNER JOIN
                         TBLWarasa ON TBLBeanWarsa.PersonId = TBLWarasa.PersonId INNER JOIN
                         CDSyndicate ON TBLWarasa.SyndicateId = CDSyndicate.SyndicateId INNER JOIN
                         TBLDofatSarf ON TBLBeanWarsa.DofatSarfId = TBLDofatSarf.DofatSarfId INNER JOIN
                         CDSubCommitte ON TBLWarasa.SubCommitteId = CDSubCommitte.SubCommitteId";
            }
        }
        public static string vQry76
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry76]
                    AS
                    SELECT    tblmemberbank.MMashatId, tblmemberbank.DofatSarfId, TBLMashat.visa, tblmemberbank.SyndicateId, tblmemberbank.SubCommitteId, tblmemberbank.summony, tblmemberbank.sendbankdate, 
                         tblmemberbank.amanatmony, tblmemberbank.amanatwareddate, tblmemberbank.datein, tblmemberbank.userin, TBLMashat.MMashatName, TBLMashat.sarfnumber, TBLDofatSarf.DofatSarf, 
                         CDSyndicate.Syndicate, CDSubCommitte.SubCommitte,TBLMashat.MMashatNId, TBLMashat.Activate
                FROM            tblmemberbank INNER JOIN
                         TBLMashat ON tblmemberbank.MMashatId = TBLMashat.MMashatId INNER JOIN
                         TBLDofatSarf ON tblmemberbank.DofatSarfId = TBLDofatSarf.DofatSarfId INNER JOIN
                         CDSyndicate ON tblmemberbank.SyndicateId = CDSyndicate.SyndicateId INNER JOIN
                         CDSubCommitte ON tblmemberbank.SubCommitteId = CDSubCommitte.SubCommitteId ";
            }
        }
        public static string vQry77
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry77]
                    AS
                    SELECT        dbo.tblWarasabank.newid, dbo.tblWarasabank.DofatSarfId, dbo.tblWarasabank.visanumber, dbo.tblWarasabank.SyndicateId, dbo.tblWarasabank.SubCommitteId, ROUND(dbo.tblWarasabank.summony, 2, 1) 
                         AS summony, dbo.tblWarasabank.sendbankdate, dbo.tblWarasabank.amanatmony, dbo.tblWarasabank.amanatwareddate, dbo.tblWarasabank.datein, dbo.tblWarasabank.userin, dbo.TBLMashat.MMashatName, 
                         dbo.TBLMashat.sarfnumber, dbo.TBLDofatSarf.DofatSarf, dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte, dbo.TBLWarasa.personNID, dbo.TBLWarasa.Activate, 
                         dbo.tblWarasabank.PersonId
                FROM            dbo.tblWarasabank INNER JOIN
                         dbo.TBLWarasa ON dbo.tblWarasabank.PersonId = dbo.TBLWarasa.PersonId INNER JOIN
                         dbo.TBLMashat ON dbo.tblWarasabank.MMashatId = dbo.TBLMashat.MMashatId INNER JOIN
                         dbo.TBLDofatSarf ON dbo.tblWarasabank.DofatSarfId = dbo.TBLDofatSarf.DofatSarfId INNER JOIN
                         dbo.CDSyndicate ON dbo.tblWarasabank.SyndicateId = dbo.CDSyndicate.SyndicateId INNER JOIN
                         dbo.CDSubCommitte ON dbo.tblWarasabank.SubCommitteId = dbo.CDSubCommitte.SubCommitteId INNER JOIN
                         dbo.AwarasaNewId ON dbo.tblWarasabank.PersonId = dbo.AwarasaNewId.personid ";
            }
        }
        public static string vTBLEstefa
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLEstefa]
                    AS
                    SELECT        TBLEstefa.MMashatId, TBLEstefa.estefadate, TBLEstefa.estefamem, TBLEstefa.finished, TBLEstefa.datein, TBLEstefa.userin, TBLMashat.MMashatName, TBLMashat.sarfnumber, TBLMashat.SyndicateId, 
                         TBLMashat.SubCommitteId, CDSyndicate.Syndicate, CDSubCommitte.SubCommitte, Users.RealName
                    FROM            TBLEstefa INNER JOIN
                         TBLMashat ON TBLEstefa.MMashatId = TBLMashat.MMashatId INNER JOIN
                         Users ON TBLEstefa.userin = Users.UserID INNER JOIN
                         CDSyndicate ON TBLMashat.SyndicateId = CDSyndicate.SyndicateId INNER JOIN
                         CDSubCommitte ON TBLMashat.SubCommitteId = CDSubCommitte.SubCommitteId";
            }
        }
        public static string vQry78
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry78]
                    AS
                    SELECT        dbo.TBLEstefa.MMashatId, dbo.TBLEstefa.estefadate, dbo.TBLEstefa.estefamem, dbo.TBLEstefa.finished, dbo.TBLEstefa.datein, dbo.TBLEstefa.userin, dbo.Users.RealName, dbo.TBLMashat.MMashatName, 
                         dbo.TBLMashat.sarfnumber, dbo.TBLMashat.SyndicateId, dbo.TBLMashat.SubCommitteId, dbo.CDSubCommitte.SubCommitte, dbo.CDSyndicate.Syndicate, dbo.TBLEstefa.estefaid
FROM            dbo.TBLEstefa INNER JOIN
                         dbo.TBLMashat ON dbo.TBLEstefa.MMashatId = dbo.TBLMashat.MMashatId INNER JOIN
                         dbo.CDSyndicate ON dbo.TBLMashat.SyndicateId = dbo.CDSyndicate.SyndicateId INNER JOIN
                         dbo.CDSubCommitte ON dbo.TBLMashat.SubCommitteId = dbo.CDSubCommitte.SubCommitteId INNER JOIN
                         dbo.Users ON dbo.TBLEstefa.userin = dbo.Users.UserID";
            }
        }
    }
}
