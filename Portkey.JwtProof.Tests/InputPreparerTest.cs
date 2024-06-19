namespace Portkey.JwtProof.Utils.Tests;

using Newtonsoft.Json;
using Extensions;

public class InputPreparerTest
{
    [Fact]
    public void TestInputPreparation()
    {
        var jwt =
            "eyJhbGciOiJSUzI1NiIsImtpZCI6IjMyM2IyMTRhZTY5NzVhMGYwMzRlYTc3MzU0ZGMwYzI1ZDAzNjQyZGMiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL2FjY291bnRzLmdvb2dsZS5jb20iLCJhenAiOiI3MzcwMjgwNDA4NTgtOHVmcXNvYzdpNWtmc3NkdGt1N3Rtc2dzc25tOGZjOGQuYXBwcy5nb29nbGV1c2VyY29udGVudC5jb20iLCJhdWQiOiI3MzcwMjgwNDA4NTgtOHVmcXNvYzdpNWtmc3NkdGt1N3Rtc2dzc25tOGZjOGQuYXBwcy5nb29nbGV1c2VyY29udGVudC5jb20iLCJzdWIiOiIxMTAxMTcyMDcxMTQyMjExMTU4NjgiLCJhdF9oYXNoIjoic2hUS2RwcWpOU3RNc3IzTDE4Z285ZyIsIm5vbmNlIjoiNDI0MjQyNDI0MjQyNDI0MjQyNDI0MjQyNDI0MjQyNDI0MjQyNDI0MjQyNDI0MjQyNDI0MjQyNDI0MjQyNDI0MiIsImlhdCI6MTcxNjQ0OTgzNSwiZXhwIjoxNzE2NDUzNDM1fQ.po6LchPr082VpjJjVliw6wItx32nBRh5a-w0T_6oQGz2N7MixGdvIeQ9gdOiyLOKPpz3NCR9oTf1V17Oxv1fgIgOP3wHThCEBToUbquAMKQjzUcujSsv3b2f0O3i28NwVBvtAYefdpvgxMEZot-S_US-2U9fBlI1ubkeLSOr4G_tLVPtR0iwfLLirW5NxR96oEp3BZ2BtSlDqLGlGXXFtNb4_Mvg40wzR4FT-RMb39zKlW0me7bcCZAwjuYEREptdYsUrHyDf72Q18NK2hBs6baNiBriNPwpHA5EyteH26SqaKYjaJGnEHPmSR4QrdwQX_LpvRlgETm_v6ZQw1t-Og";
        var pubkey =
            "xjWd1j8GmmWzuz732haG9HECXsSZBvxOBLph3FQhk_tplhWloI1ywx-RdopUZt1lndbOM9n99lZJkpQyNJ1sdy7JFgYLjqj-wtHdEaQlBGEQtmkW8zUjr_N3bmpsxGbPzOzlKe3qddtoxXvn9rI_RvHfJD1YY-6kayQeyPOBz_4ML1lvI_JHV-Bb1MSmSk3WaAh5PzeqleusmUT87Gqfu02cOPrY8cwugqo65D6-wzAEeVvceV8-c36TMoLU5csU05GBVplgd6Ouuw35ZsETG4si4QQJztC3KsZ4jhYM-aJ3jeFPt0r3cQooiXdZBp3JkXSpE-UUaOVPsXo7WiVmww==";
        var expected =
            "{\"jwt\":[\"101\",\"121\",\"74\",\"104\",\"98\",\"71\",\"99\",\"105\",\"79\",\"105\",\"74\",\"83\",\"85\",\"122\",\"73\",\"49\",\"78\",\"105\",\"73\",\"115\",\"73\",\"109\",\"116\",\"112\",\"90\",\"67\",\"73\",\"54\",\"73\",\"106\",\"77\",\"121\",\"77\",\"50\",\"73\",\"121\",\"77\",\"84\",\"82\",\"104\",\"90\",\"84\",\"89\",\"53\",\"78\",\"122\",\"86\",\"104\",\"77\",\"71\",\"89\",\"119\",\"77\",\"122\",\"82\",\"108\",\"89\",\"84\",\"99\",\"51\",\"77\",\"122\",\"85\",\"48\",\"90\",\"71\",\"77\",\"119\",\"89\",\"122\",\"73\",\"49\",\"90\",\"68\",\"65\",\"122\",\"78\",\"106\",\"81\",\"121\",\"90\",\"71\",\"77\",\"105\",\"76\",\"67\",\"74\",\"48\",\"101\",\"88\",\"65\",\"105\",\"79\",\"105\",\"74\",\"75\",\"86\",\"49\",\"81\",\"105\",\"102\",\"81\",\"46\",\"101\",\"121\",\"74\",\"112\",\"99\",\"51\",\"77\",\"105\",\"79\",\"105\",\"74\",\"111\",\"100\",\"72\",\"82\",\"119\",\"99\",\"122\",\"111\",\"118\",\"76\",\"50\",\"70\",\"106\",\"89\",\"50\",\"57\",\"49\",\"98\",\"110\",\"82\",\"122\",\"76\",\"109\",\"100\",\"118\",\"98\",\"50\",\"100\",\"115\",\"90\",\"83\",\"53\",\"106\",\"98\",\"50\",\"48\",\"105\",\"76\",\"67\",\"74\",\"104\",\"101\",\"110\",\"65\",\"105\",\"79\",\"105\",\"73\",\"51\",\"77\",\"122\",\"99\",\"119\",\"77\",\"106\",\"103\",\"119\",\"78\",\"68\",\"65\",\"52\",\"78\",\"84\",\"103\",\"116\",\"79\",\"72\",\"86\",\"109\",\"99\",\"88\",\"78\",\"118\",\"89\",\"122\",\"100\",\"112\",\"78\",\"87\",\"116\",\"109\",\"99\",\"51\",\"78\",\"107\",\"100\",\"71\",\"116\",\"49\",\"78\",\"51\",\"82\",\"116\",\"99\",\"50\",\"100\",\"122\",\"99\",\"50\",\"53\",\"116\",\"79\",\"71\",\"90\",\"106\",\"79\",\"71\",\"81\",\"117\",\"89\",\"88\",\"66\",\"119\",\"99\",\"121\",\"53\",\"110\",\"98\",\"50\",\"57\",\"110\",\"98\",\"71\",\"86\",\"49\",\"99\",\"50\",\"86\",\"121\",\"89\",\"50\",\"57\",\"117\",\"100\",\"71\",\"86\",\"117\",\"100\",\"67\",\"53\",\"106\",\"98\",\"50\",\"48\",\"105\",\"76\",\"67\",\"74\",\"104\",\"100\",\"87\",\"81\",\"105\",\"79\",\"105\",\"73\",\"51\",\"77\",\"122\",\"99\",\"119\",\"77\",\"106\",\"103\",\"119\",\"78\",\"68\",\"65\",\"52\",\"78\",\"84\",\"103\",\"116\",\"79\",\"72\",\"86\",\"109\",\"99\",\"88\",\"78\",\"118\",\"89\",\"122\",\"100\",\"112\",\"78\",\"87\",\"116\",\"109\",\"99\",\"51\",\"78\",\"107\",\"100\",\"71\",\"116\",\"49\",\"78\",\"51\",\"82\",\"116\",\"99\",\"50\",\"100\",\"122\",\"99\",\"50\",\"53\",\"116\",\"79\",\"71\",\"90\",\"106\",\"79\",\"71\",\"81\",\"117\",\"89\",\"88\",\"66\",\"119\",\"99\",\"121\",\"53\",\"110\",\"98\",\"50\",\"57\",\"110\",\"98\",\"71\",\"86\",\"49\",\"99\",\"50\",\"86\",\"121\",\"89\",\"50\",\"57\",\"117\",\"100\",\"71\",\"86\",\"117\",\"100\",\"67\",\"53\",\"106\",\"98\",\"50\",\"48\",\"105\",\"76\",\"67\",\"74\",\"122\",\"100\",\"87\",\"73\",\"105\",\"79\",\"105\",\"73\",\"120\",\"77\",\"84\",\"65\",\"120\",\"77\",\"84\",\"99\",\"121\",\"77\",\"68\",\"99\",\"120\",\"77\",\"84\",\"81\",\"121\",\"77\",\"106\",\"69\",\"120\",\"77\",\"84\",\"85\",\"52\",\"78\",\"106\",\"103\",\"105\",\"76\",\"67\",\"74\",\"104\",\"100\",\"70\",\"57\",\"111\",\"89\",\"88\",\"78\",\"111\",\"73\",\"106\",\"111\",\"105\",\"99\",\"50\",\"104\",\"85\",\"83\",\"50\",\"82\",\"119\",\"99\",\"87\",\"112\",\"79\",\"85\",\"51\",\"82\",\"78\",\"99\",\"51\",\"73\",\"122\",\"84\",\"68\",\"69\",\"52\",\"90\",\"50\",\"56\",\"53\",\"90\",\"121\",\"73\",\"115\",\"73\",\"109\",\"53\",\"118\",\"98\",\"109\",\"78\",\"108\",\"73\",\"106\",\"111\",\"105\",\"78\",\"68\",\"73\",\"48\",\"77\",\"106\",\"81\",\"121\",\"78\",\"68\",\"73\",\"48\",\"77\",\"106\",\"81\",\"121\",\"78\",\"68\",\"73\",\"48\",\"77\",\"106\",\"81\",\"121\",\"78\",\"68\",\"73\",\"48\",\"77\",\"106\",\"81\",\"121\",\"78\",\"68\",\"73\",\"48\",\"77\",\"106\",\"81\",\"121\",\"78\",\"68\",\"73\",\"48\",\"77\",\"106\",\"81\",\"121\",\"78\",\"68\",\"73\",\"48\",\"77\",\"106\",\"81\",\"121\",\"78\",\"68\",\"73\",\"48\",\"77\",\"106\",\"81\",\"121\",\"78\",\"68\",\"73\",\"48\",\"77\",\"106\",\"81\",\"121\",\"78\",\"68\",\"73\",\"48\",\"77\",\"106\",\"81\",\"121\",\"78\",\"68\",\"73\",\"48\",\"77\",\"105\",\"73\",\"115\",\"73\",\"109\",\"108\",\"104\",\"100\",\"67\",\"73\",\"54\",\"77\",\"84\",\"99\",\"120\",\"78\",\"106\",\"81\",\"48\",\"79\",\"84\",\"103\",\"122\",\"78\",\"83\",\"119\",\"105\",\"90\",\"88\",\"104\",\"119\",\"73\",\"106\",\"111\",\"120\",\"78\",\"122\",\"69\",\"50\",\"78\",\"68\",\"85\",\"122\",\"78\",\"68\",\"77\",\"49\",\"102\",\"81\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\"],\"signature\":[\"2590504618963973663904969213213376058\",\"431319723829552705047905030107957295\",\"34896935199175615164816415705868954\",\"2074655984522474733342644404888195505\",\"2302413550139804866586374796549337418\",\"1466207327557347204096675688527653171\",\"1104114691164900874770164249296842627\",\"1294946077213505289519822965144500995\",\"2293557551205359481591942609170286768\",\"510803360218625015255293784894941466\",\"2597354655430984267244009230025205496\",\"736442885734904270951410008082593715\",\"1227650358441402704477766260000576417\",\"1444870397893044257658896432782555894\",\"835994325592910534674555235638576974\",\"1837221571966615781094610665346736125\",\"3378173549611186639396903890146904\"],\"pubkey\":[\"1934963734829801902778836036538951363\",\"1249555810634354950342895371056768200\",\"337549027625320863817263092614077923\",\"1096468248024488332026038222400349276\",\"2107827172249430178499079678371371029\",\"2068510740493391395746205507720503011\",\"455273099858599328331097570680236899\",\"912560724110187204370925704955457365\",\"556308369645217404811893737628365383\",\"512697797783475511538061586484819794\",\"2469476794444033608932642323294942938\",\"2171445279971411885712022799864168046\",\"1512456018287931122507905868837432605\",\"847458270583891289605754637085611169\",\"697388917958177267215723285707086377\",\"1401451281005718950097983512726714536\",\"4020165042290584996921747952884246\"],\"salt\":[\"166\",\"119\",\"153\",\"147\",\"150\",\"220\",\"73\",\"162\",\"138\",\"214\",\"201\",\"194\",\"66\",\"113\",\"155\",\"179\"],\"payload_start_index\":[\"103\"],\"sub_claim\":[\"34\",\"115\",\"117\",\"98\",\"34\",\"58\",\"34\",\"49\",\"49\",\"48\",\"49\",\"49\",\"55\",\"50\",\"48\",\"55\",\"49\",\"49\",\"52\",\"50\",\"50\",\"49\",\"49\",\"49\",\"53\",\"56\",\"54\",\"56\",\"34\",\"44\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\",\"0\"],\"sub_claim_length\":[\"30\"],\"sub_index_b64\":[\"368\"],\"sub_length_b64\":[\"41\"],\"sub_name_length\":[\"5\"],\"sub_colon_index\":[\"5\"],\"sub_value_index\":[\"6\"],\"sub_value_length\":[\"23\"],\"nonce_claim\":[\"34\",\"110\",\"111\",\"110\",\"99\",\"101\",\"34\",\"58\",\"34\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"52\",\"50\",\"34\",\"44\",\"0\",\"0\"],\"nonce_claim_length\":[\"75\"],\"nonce_index_b64\":[\"455\"],\"nonce_length_b64\":[\"101\"],\"nonce_name_length\":[\"7\"],\"nonce_colon_index\":[\"7\"],\"nonce_value_index\":[\"8\"],\"nonce_value_length\":[\"66\"]}";

        var args = InputPreparer.Prepare(jwt, pubkey, "a677999396dc49a28ad6c9c242719bb3".DecodeHex());
        var jsonString = JsonConvert.SerializeObject(args, Formatting.None);
        Assert.Equal(expected, jsonString);
    }

    // TODO: Add negative test cases
}