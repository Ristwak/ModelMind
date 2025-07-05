using UnityEngine;
using TMPro;

/// <summary>
/// Populates the About panel with det,vkbZled game info for OptiMind (multi-correct logic game).
/// </summary>
public class AboutGameManager : MonoBehaviour
{
    [Header("UI Reference")]
    [Tooltip("Assign the TMP_Text component for the About section.")]
    public TMP_Text aboutText;

    void Start()
    {
        if (aboutText == null)
        {
            Debug.LogError("AboutGameManager: 'aboutText' reference is missing.");
            return;
        }

        aboutText.text =
            "<b>e‚MyekbaM ds ckjs esa</b>\n" +
            "e‚MyekbaM ,d ,vkbZ@,e,y vkèkkfjr f'k{k.k xse gS] ftls fo|kfFkZ;ksa dks e'khu yfuZax vkSj vkfVZfQf'k;y baVsfytsal dh lksp vkSj rdZ dks le>kus ds fy, fMt+kbu fd;k x;k gSA\n\n" +

            "<b>;g xse D;k gS\\</b>\n" +
            "bl xse esa vki ,d ,vkbZ bathfu;j dh Hkwfedk fuHkkrs gSaA vkidks MsVk dks lkQ+ djuk] lgh ,Yxksfjn~e pquuk] e‚My dks Vªsu djuk vkSj mldh Hkfo\";ok.kh dks ij[kuk gksrk gSA gj fu.kZ; vkids e‚My dh lVhdrk vkSj fu\"i{krk dks çHkkfor djrk gSA\n\n" +

            "<b>lksfp, tSls ,d e‚My lksprk gS</b>\n" +
            "e‚MyekbaM mu y,Yxksfjnfed i{kikr ¼i{kikr½ vkSj mlds lekèkkuksxksa ds fy, gS tks dsoy ifj.kke ugha] cfYd e'khu dh lkspus dh çfØ;k dks Hkh le>uk pkgrs gSaA ;g xse fu.kZ; o`{k ¼fu.kZ; ds isM+½] U;wjy usVoDlZ] ck;l fMVsD'ku vkSj e‚My ,DlIyusfcfyVh tSls fo\"k;ksa dks baVj,sfDVo :i esa fl[kkrk gSA\n\n" +

            "<b>vki D;k lh[ksaxs:</b>\n" +
            "• MsVk Dyhfuax vkSj çh&çkslsflax dh rduhdsa\n" +
            "• fofHkUu e'khu yfuZax ,Yxksfjn~e dk p;u vkSj rqyuk\n" +
            "• e‚My ds çn'kZu dks ekius ds fy, ehfVªDl tSls 'kq)rk] ,Q1&vad\n" +
            "• ,Yxksfjnfed i{kikr ¼i{kikr½ vkSj mlds lekèkku\n" +
            "• fdlh Hkh fu.kZ; ds ihNs fNis rdZ dks le>uk ¼O;k[;kf;Ro½\n\n" +

            "<b>fo'ks\"k :i ls ,vkbZ@,e,y Nk=ksa ds fy,</b>\n" +
            "e‚MyekbaM fo'ks\"k :i ls iksLVxzstq,V Nk=ksa vkSj VsDuksy‚th ds çfr mRlkgh yksxksa ds fy, cuk;k x;k gS tks O;kogkfjd Kku ds lkFk xgjh le> çkIr djuk pkgrs gSa:\n" +
            "• MsVk vkèkkfjr fu.kZ; ysuk\n" +
            "• okLrfod thou dh leL;kvksa dks e‚My ds ekè;e ls gy djuk\n" +
            "• lhfer lalkèkuksa esa çHkkoh e‚My cukuk\n\n" +

            "<b>D;k vki rS;kj gSa e'khu dh rjg lkspus ds fy,\\</b>\n" +
            ";g dsoy ,d xse ugha — ;g ,d vuqHko gS tks vkidh lksp] rdZ vkSj fu.kZ; ysus dh {kerk dks pqukSrh nsxkA\n" +
            "lksfp,A cukb,A ijf[k,A\n\n" +
            "<b>e‚MyekbaM esa vkidk Lokxr gS!</b>";
    }
}
