﻿using Aurora.EffectsEngine;
using Aurora.Profiles;
using Aurora.Settings.Overrides;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Aurora.Settings.Layers
{
    public class GradientFillLayerHandlerProperties : LayerHandlerProperties2Color<GradientFillLayerHandlerProperties>
    {
        [Overrides.LogicOverridable("Gradient")]
        public LayerEffectConfig _GradientConfig { get; set; }

        [JsonIgnore]
        public LayerEffectConfig GradientConfig { get { return Logic._GradientConfig ?? _GradientConfig; } }

        public bool? _FillEntireKeyboard { get; set; }

        [JsonIgnore]
        public bool FillEntireKeyboard { get { return Logic._FillEntireKeyboard ?? _FillEntireKeyboard ?? false; } }

        public GradientFillLayerHandlerProperties() : base() { }

        public GradientFillLayerHandlerProperties(bool assign_default = false) : base(assign_default) { }

        public override void Default()
        {
            base.Default();
            this._GradientConfig = new LayerEffectConfig(Utils.ColorUtils.GenerateRandomColor(), Utils.ColorUtils.GenerateRandomColor()) { AnimationType = AnimationType.None };
            this._FillEntireKeyboard = false;
        }
    }

    [LogicOverrideIgnoreProperty("_PrimaryColor")]
    [LogicOverrideIgnoreProperty("_SecondaryColor")]
    public class GradientFillLayerHandler : LayerHandler<GradientFillLayerHandlerProperties>
    {
        readonly EffectLayer _gradientLayer = new("GradientFillLayer");
        
        protected override UserControl CreateControl()
        {
            return new Control_GradientFillLayer(this);
        }

        public override EffectLayer Render(IGameState gamestate)
        {
            //Get current color
            Properties.GradientConfig.shift_amount += ((Utils.Time.GetMillisecondsSinceEpoch() - Properties.GradientConfig.last_effect_call) / 1000.0f) * 5.0f * Properties.GradientConfig.speed;
            Properties.GradientConfig.shift_amount %= Effects.CanvasBiggest;
            Properties.GradientConfig.last_effect_call = Utils.Time.GetMillisecondsSinceEpoch();

            Color selected_color = Properties.GradientConfig.brush.GetColorSpectrum().GetColorAt(Properties.GradientConfig.shift_amount, Effects.CanvasBiggest);

            if (Properties.FillEntireKeyboard)
                _gradientLayer.FillOver(selected_color);
            else
                _gradientLayer.Set(Properties.Sequence, selected_color);

            return _gradientLayer;
        }
    }
}
