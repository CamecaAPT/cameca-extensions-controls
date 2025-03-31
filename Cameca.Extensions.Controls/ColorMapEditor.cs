using System.Windows;
using System.Windows.Controls;
using Cameca.CustomAnalysis.Interface;

namespace Cameca.Extensions.Controls;

public class ColorMapEditor : Control
{
	public static readonly DependencyProperty ColorMapProperty = DependencyProperty.Register(
		nameof(ColorMap), typeof(IColorMap), typeof(ColorMapEditor), new FrameworkPropertyMetadata(null));

	public IColorMap? ColorMap
	{
		get => GetValue(ColorMapProperty) as IColorMap;
		set => SetValue(ColorMapProperty, value);
	}

	public static readonly DependencyProperty ValueLabelProperty = DependencyProperty.Register(
		nameof(ValueLabel), typeof(string), typeof(ColorMapEditor), new FrameworkPropertyMetadata(null));

	public string? ValueLabel
	{
		get => (string)GetValue(ValueLabelProperty);
		set => SetValue(ValueLabelProperty, value);
	}
}
