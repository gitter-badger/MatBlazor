using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace MatBlazor
{
    /// <summary>
    /// Text fields allow users to input, edit, and select text.
    /// </summary>
    public class BaseMatTextField : BaseMatComponent
    {
        [Parameter]
        public string Value
        {
            get => _value;
            set
            {
                if (value != _value)
                {
                    _value = value;
                    LabelClassMapper.MakeDirty();
                    InputClassMapper.MakeDirty();
                    ValueChanged.InvokeAsync(value);
                }
            }
        }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        [Parameter]
        public EventCallback<UIFocusEventArgs> OnFocus { get; set; }

        [Parameter]
        public EventCallback<UIFocusEventArgs> OnFocusOut { get; set; }

        [Parameter]
        public EventCallback<UIKeyboardEventArgs> OnKeyPress { get; set; }

        [Parameter]
        public EventCallback<UIKeyboardEventArgs> OnKeyDown { get; set; }

        [Parameter]
        public EventCallback<UIKeyboardEventArgs> OnKeyUp { get; set; }

        [Parameter]
        public EventCallback<UIChangeEventArgs> OnInput { get; set; }

        [Parameter]
        public string Label { get; set; }

        [Parameter]
        public string Icon { get; set; }

        [Parameter]
        public bool IconTrailing { get; set; }

        [Parameter]
        public bool Box { get; set; }

        [Parameter]
        public bool TextArea { get; set; }

        [Parameter]
        public bool Dense { get; set; }

        [Parameter]
        public bool Outlined { get; set; }

        [Parameter]
        public bool Disabled { get; set; }

        [Parameter]
        public bool FullWidth { get; set; }

        [Parameter]
        public bool Required { get; set; }

        [Parameter]
        public string HelperText { get; set; }

        [Parameter]
        public string PlaceHolder { get; set; }

        [Parameter]
        public bool HideClearButton { get; set; }

        [Parameter]
        public string Type { get; set; } = "text";

        protected ClassMapper LabelClassMapper = new ClassMapper();
        protected ClassMapper InputClassMapper = new ClassMapper();

        private string _value;

        public BaseMatTextField()
        {
            ClassMapper
                .Add("mdc-text-field")
                .Add("_mdc-text-field--upgraded")
                .If("mdc-text-field--with-leading-icon", () => this.Icon != null && !this.IconTrailing)
                .If("mdc-text-field--with-trailing-icon", () => this.Icon != null && this.IconTrailing)
                .If("mdc-text-field--box", () => !this.FullWidth && this.Box)
                .If("mdc-text-field--dense", () => Dense)
                .If("mdc-text-field--outlined", () => !this.FullWidth && this.Outlined)
                .If("mdc-text-field--disabled", () => this.Disabled)
                .If("mdc-text-field--fullwidth", () => this.FullWidth)
                .If("mdc-text-field--fullwidth-with-leading-icon", () => this.FullWidth && this.Icon != null && !this.IconTrailing)
                .If("mdc-text-field--fullwidth-with-trailing-icon", () => this.FullWidth && this.Icon != null && this.IconTrailing)
                .If("mdc-text-field--textarea", () => this.TextArea);

            LabelClassMapper
                .Add("mdc-floating-label")
                .If("mdc-floating-label--float-above", () => !string.IsNullOrEmpty(Value));

            InputClassMapper
                .Add("mdc-text-field__input")
                .If("_mdc-text-field--upgraded", () => !string.IsNullOrEmpty(Value))
                .If("mat-hide-clearbutton", () => this.HideClearButton);
        }

        protected async override Task OnFirstAfterRenderAsync()
        {
            await base.OnFirstAfterRenderAsync();
            await Js.InvokeAsync<object>("matBlazor.matTextField.init", Ref);
        }
    }
}