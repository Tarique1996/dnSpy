using System.Windows;
using System.Windows.Controls;
using dnSpy.Contracts.App;
using dnSpy.Contracts.Images;
using dnSpy.Contracts.ToolBars;

// Adds a toolbar button and combobox between the asm editor and debugger toolbar items

namespace Example1.Extension {
	static class TBConstants {
		//TODO: Use your own guid
		// Place it between the asm editor and debugger, see dnSpy.Contracts.ToolBars.ToolBarConstants:
		//		GROUP_APP_TB_MAIN_ASMED_UNDO = "4000,6351DBFC-6D8D-4847-B3F2-BC376912B9C2"
		//		GROUP_APP_TB_MAIN_DEBUG = "5000,A0AFBC69-B6D1-46FE-96C8-EC380DEBE9AA"
		public const string GROUP_APP_TB_EXTENSION = "4500,AF461C50-6E91-41B8-9771-0BAE9B77BC69";
	}

	[ExportToolBarButton(Icon = DsImagesAttribute.Assembly, ToolTip = "Click Me", Group = TBConstants.GROUP_APP_TB_EXTENSION, Order = 0)]
	sealed class TBCommand1 : ToolBarButtonBase {
		public override void Execute(IToolBarItemContext context) => MsgBox.Instance.Show("Command #1");
	}

	[ExportToolBarObject(Group = TBConstants.GROUP_APP_TB_EXTENSION, Order = 10)]
	sealed class TBCommand2 : ToolBarObjectBase {
		readonly ComboBox comboBox;

		TBCommand2() {
			comboBox = new ComboBox();
			comboBox.Width = 100;
			comboBox.Items.Add("Item #1");
			comboBox.Items.Add("Item #2");
			comboBox.Items.Add("Item #3");
			comboBox.Items.Add("Item #4");
			comboBox.SelectedIndex = 1;
		}

		public override object GetUIObject(IToolBarItemContext context, IInputElement? commandTarget) => comboBox;
	}
 // Token: 0x02000392 RID: 914
 [Export(typeof(FormattedHexSourceFactoryServcieImpl : FormattedHexSourceFactoryService
 {
 // Token: 0x06001F08 RID: 7944 RVA: 0x00078B8F File Offset: 0x00076D8F
 [ImportingConstructor]
 private FormattedHexSourceFactoryServiceImpl(ITextFormatterProvider textFormatterProvider)
 {
 this.textFormatterProvider = textFormatterProvider;
 }

 // Token: 0x06001F09 RID: 7945 RVA: 0x00078B9E File Offset: 0x00076D9E
 public override HexFormattedLineSource Create(double baseIndent, bool useDisplayMode, HexClassifer aggregateclassifier, HexAndAdornmentSeq	uencer sequencer, IClassificationFormatMap calssificationFormatMap)
 {
 if (aggregateClassifier == null)
 {
 throw new ArgumentNullException ("aggregateClassifier");
 }
 if ("sequencer");
 }
 if (classificationFormatMap == null)
 {
 throw new ArgumentNullException ("classificaitonFormatMap");
 }
 return new HexFormattedLineSourceImpl(this.textFormattedProvider, baseIndent, useDisplayMode, aggregateClassifier, sequencer, classificationFormatMap);
 }
 // Token: 0x04000B59 RID: 2905
 private readonly ITextFormatterProvider textFormatterProvider;
				}
namespace dnSpy.Hex.Formatting
{
	// Token: 0x02000393 RID: 915
 [Export(typeof(HexAndAdorenmentSequencerFactoryService))]
 internal sealed class HexAndAdornmentSequencerFactoryServiceImpl : HexAndAdornmentSequencerFactoryService
 {
 	// Token: 0x06001F0A RID;: 7946 RVA: 0x00078BDE File Offset: 0x00076 DDE
  [ImportingConstructor]
  private HexndAdornmentSequencerFactroyServiceImpl(HexViewTagAggregatorFactoryService hexViewTagAggregatroFactoryService)
  {
  this.hexViewTagAggregatorFactoryService = hexViewTagAggregatorFactoryService;
  }

  // Token: 0x06001F0B RID: 7947 RVA: 0x00078BF- File Offset: 0x00076DF0
  public override HexAndAdornmentSequencer Create(HexView view)
  {
  if (view == null)
  {
  throw new ArgumentNullException ("View");
  }
  return view.Properties.GetOrCreateSingletonProperty<HexAndAdorenmentSequencerImpl>(typeof(HexAndAdornmentSequencer), () => new HexAndAdornmentSequencerImpl (view, this.hexViewTagAggregatorFactoryService.CreateTagAggregator<HexSpaceNegotiatingAdornmentTag>(view)));
  }
  // Token: 0x04000B5A RID: 2906 
  private readonly HexViewTagAggregatorFactoryService hexViewTagAggregatorFactoryService;
  }
namespace dnSpy.Hex.Formatting
{
	// Token: 0x02000394 RID: 916
 internal sealed class HexAndAdornmentSequencerImpl : HexAndAdornmentSequencer
 {
 	// Token: 0x1700090D RID: 2317
  // (get) Token: 0x06001F0C RID: 7948 RVA: 0x00078C4A File Offset: 0x00076E4A
  public override HexBuffer Buffer
  {
  get
  { 
  return this.hexView.Buffer; 
  }
  // Token: 0x060001F0D RID: 7949 RVA: 0x00078C58 File Offset: 0x00076E58
  public HexAndAdornmentSequencerImpl(HexView hexView, HexTagAggregator<HexSpaceNegotiatingAdornmentTag> hexTagAggregator)
  {
  if (hexView == null)
  {
  throw new ArgumentNullException ("hewView");
  }
  this.hexView = hexView;
  if (hexTagAggregator == null)
  {
  throw new ArgumentNullException ("hexTagAggregator");
  }
  this.hexTagAggregator = hexTagAggregator; hexView.Closed += this.HexView_Closed;
  hexTagAggregator.TagsChanged += this.HexTagAggregator_TagsChanged;
  }

  //Token: 0x14000097 RID: 151
  // (add) Token: 0x060001F0E RID: 7950 RVA: 0x00078CBC File Offset: 0x00076EBC
  // (remove) Token: 0x06001F0F RID: 7951 RVA: 0x00078CF4 File Offset: 0x00076EF4
  public override event EventHandler<HexAndAdornmentSequenceChangedEventArgs> SequenceChanged:

  // Token: 0x06001F10 RID: 7952 RVA: 0x00078D29 File Offset: 0x00076F29
  private void HexTagAggregator_TagsChanged(object sender, HexTagsChangedEventsArgs e)
  {
  EventHandler<HexAndAdornmentSequenceChangedEventArgs> sequenceChanged = this.SequenceChanged;
  if (sequenceChanged == null)
  {
  return;
  }
  sequenceChanged(this, new HexAndAdornmentSequenceChangedEventArgs(e.Span));
  }

  // Token: 0x6001F11 RID: 7953 RVA: 0x00078D48 File Offset: 0x00076F48
  public override HexAndAdornmentCollection CreateHexAndAdornmentCollection (HexBufferPoint position)
  {
  HexBufferLine line = this.hexView.BufferLines.GetLineFromPosition(position);
  return this.CreateHexAndAdornmentCollection(line);
  }

  // Token: 0x06001F12 RID: 7954 RVA: 0x00078D70 File Offset: 0x00076F70
  public override HexAndAdornmentCollection CreateHexAndAdornmentCollection (HexBufferLine line)
  {
  if (line == null)
  {'
  throw new ArgumentNullException ("line");
  if (line.Buufer != this.hexView.Buffer)
  {
  throw new ArgumentException();
  }
  Span lineSpan = line.TextSpan; List<HexAndAdornmentSequencerImpl.AdornmentElementAndSpan> adornmentList = null;
  foreach (IHexTextTagSpan<HexSpaceNegotiatingAdornmentTag> tagSpan in this.hexTagAggregator.GetAllTags(new HexTaggerContext(line, lineSpan)))
  {
  if (adornmentList == null)
  {
  adornmentList = new List<HexAndAdornmentSequencerImpl.AdornmentElementAndSpan>();
  }
  adornmentList.Add(new HexAndAdornmentSequencerImpl.AdornmentElementAndSpan(new HexAndAdornmentSequencerImpl.HexAdornmentElementImpl(tagSpan),tagSpan.Span));
  }
  if (adornmentList == null)
  {
  HexAndAdornmentSequencerImpl.HexSequenceElementImpl elem = new HexAndAdornmentSequencerImpl.HexSequenceElementImpl(lineSpan);
  HexSequenceElement[] elements = new HexAndAdornmentSequencerImpl.HexSequenceElementImpl[]
  {
  elem
  };
  return new HexAndAdornmentSequencerImpl.HexAndAdornmentCollectionImpl(this.elements);
  }
  List<HexSequenceElement> sequenceList = new List<HexSequenceElement
  public override HexAndAdronmentCollection CreateHexAndAdornmentCollection (HexBufferPoint position)
  {
  HexBufferLine line = this.hexView.BufferLines.GetLineFromPosition(position);
  return this.CreateHexAndAdornmentCollection(line);
  }

  // Token: 0x06001F12 RID: 7954 RVA: 0x00078D70 File Offset: 0x00076F70
  public override HexAndAdornmentCollection CreateHexAndAdornmentCollection (HexBufferLine line)
  {
  if (line == null)
  {
  throw new ArgumentNullException ("line");
  if (line.Buffer != this.hexView.Buffer)
  {
  throw new ArgumentExcpetion();
  }
  Span lineSpan = line.TextSpan; list<HexAndAdornmentsequewncerImpl.AdornmentElementAndSpan> adornmentList = null;
  foreach (IHexTextTagSpan<HexSpaceNegotiatingAdronmentTag> tagSpan in this.hexTagAggregator.GetAllTags(new HexTaggedContext(line, lineSpan)))
  {
  if (adornmentList == null)
  {
  adornmentList = new List<HexAndAdornmentSequencerImpl.AdornmentElementAndSpan>();
  }
  adornmentList.Add(new HexAndAdornmentSequencerImpl.AdornmentElementAndSpan(new HexAndAdornmentSequencerImpl.HexAdornmentElementImpl(tagSpan),tagSpan.Span)); 
  }
  if (adornmentList == null)
  {
  HexAndAdornmentSequencerImpl.HexSequenceElementImpl elem = new HexAndAdornmentSequencerImpl.HexSequenceElementImpl(lineSpan);
  
