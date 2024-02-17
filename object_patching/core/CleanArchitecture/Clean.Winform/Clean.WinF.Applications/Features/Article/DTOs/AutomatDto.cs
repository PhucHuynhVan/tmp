using Clean.WinF.Applications.DTOs;

namespace Clean.WinF.Applications.Features.Article.DTOs
{
    public class AutomatDto : BaseDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public long SerialId { get; set; }
        public long MinETMMeasVal { get; set; }
        public long AutoLogout { get; set; }
        public bool IsAutoLogout { get; set; }
        public string ControllDescription { get; set; }

        public bool AllocationToAnArticleIsPossible { get; set; }

        public bool OneCriticalSectionNoSeamsWithFLPart { get; set; }
        public bool OneCriticalSectionNoSeamsWithEndLabel { get; set; }

        public bool OneCriticalSectionTwoSeamsWithFLPart { get; set; }
        public bool OneCriticalSectionTwoSeamsWithEndLabelBehind { get; set; }
        public bool OneCriticalSectionTwoSeamsWithEndLabel { get; set; }

        public bool ThreeCriticalSectionTwoSeamsWithFLPart { get; set; }
        public bool ThreeCriticalSectionTwoSeamsWithEndLabel { get; set; }

        public bool TwoCriticalSectionFourSeamsWithFLPart { get; set; }
        public bool TwoCriticalSectionFourSeamsWithEndLabelBehind { get; set; }
        public bool TwoCriticalSectionFourSeamsWithEndLabel { get; set; }

        public bool ThreeCriticalSectionFourSeamsWithFLPart { get; set; }
        public bool ThreeCriticalSectionFourSeamsWithEndLabelBehind { get; set; }
        public bool ThreeCriticalSectionFourSeamsWithEndLabel { get; set; }

        public bool OneCriticalSectionTwoSeamsWithTwoEndLabel { get; set; }
        public bool TwoCriticalSectionFourSeamsWithTwoEndLabel { get; set; }
        public bool ThreeCriticalSectionFourSeamsWithTwoEndLabel { get; set; }
        public bool Custom { get; set; }

        public bool Part1 { get; set; }
        public bool Part2 { get; set; }
        public bool Part3 { get; set; }
        public bool Part4 { get; set; }
        public bool Part5 { get; set; }
        public bool UpperThread { get; set; }
        public bool LowerThread { get; set; }

        public bool AutoTolCrit { get; set; }
        public string AutoTolCritText { get; set; }
        public bool AutoTolNotCrit { get; set; }
        public string AutoTolNotCritText { get; set; }

        public bool EnableStitchLength { get; set; }
        public string EnableStitchLengthMin { get; set; }
        public string EnableStitchLengthMax { get; set; }

        public bool Info1 { get; set; }
        public bool Info2 { get; set; }
        public bool Info3 { get; set; }
        public bool Info4 { get; set; }
        public bool Info5 { get; set; }
        public bool Info6 { get; set; }
        public bool Info7 { get; set; }

        public bool ExactLength1 { get; set; }
        public bool ExactLength2 { get; set; }
        public bool ExactLength3 { get; set; }
        public bool ExactLength4 { get; set; }
        public bool ExactLength5 { get; set; }
        public bool ExactLength6 { get; set; }
        public bool ExactLength7 { get; set; }

        public string LabelText1 { get; set; }
        public string LabelText2 { get; set; }
        public string LabelText3 { get; set; }
        public string LabelText4 { get; set; }
        public string LabelText5 { get; set; }
        public string LabelText6 { get; set; }
        public string LabelText7 { get; set; }
        public string ArticleCodeMaxLength { get; set; }
        public bool ArticleCodeExactLength { get; set; }
        public bool ETM422 { get; set; }
        public bool ETM14600 { get; set; }
        public bool PrintArticleLabelEnabled { get; set; }
        public bool ETM14600ValuesAreEditable { get; set; }
    }
}