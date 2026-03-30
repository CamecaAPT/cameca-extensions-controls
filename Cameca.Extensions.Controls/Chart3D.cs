using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Cameca.Extensions.Controls;

public class Chart3D : Control
{
	public const bool IsToolbarVisibleDefault = true;
	public const bool IsScaleBarVisibleDefault = true;
	public const bool IsAxisVisibleDefault = true;

	public static readonly RoutedEvent Chart3DSyncEvent = EventManager.RegisterRoutedEvent(
		name: nameof(Chart3DSync),
		routingStrategy: RoutingStrategy.Bubble,
		handlerType: typeof(Chart3DSyncRoutedEventHandler),
		ownerType: typeof(Chart3D));

	public event Chart3DSyncRoutedEventHandler Chart3DSync
	{
		add { AddHandler(Chart3DSyncEvent, value); }
		remove { RemoveHandler(Chart3DSyncEvent, value); }
	}

	public static readonly RoutedEvent Chart3DReleaseSyncEvent = EventManager.RegisterRoutedEvent(
		name: nameof(Chart3DReleaseSync),
		routingStrategy: RoutingStrategy.Bubble,
		handlerType: typeof(Chart3DSyncRoutedEventHandler),
		ownerType: typeof(Chart3D));

	public event Chart3DSyncRoutedEventHandler Chart3DReleaseSync
	{
		add { AddHandler(Chart3DReleaseSyncEvent, value); }
		remove { RemoveHandler(Chart3DReleaseSyncEvent, value); }
	}

	public void Sync(Chart3D? syncChart)
	{
		var routedEventArgs = new Chart3DSyncRoutedEventArgs(Chart3DSyncEvent, syncChart);
		RaiseEvent(routedEventArgs);
	}

	public void ReleaseSync(Chart3D? syncChart)
	{
		var routedEventArgs = new Chart3DSyncRoutedEventArgs(Chart3DReleaseSyncEvent, syncChart);
		RaiseEvent(routedEventArgs);
	}

	public static readonly IEnumerable DataSourceDefault = Enumerable.Empty<object>();

	public static readonly DependencyProperty DataSourceProperty = DependencyProperty.Register(
		nameof(DataSource), typeof(IEnumerable), typeof(Chart3D), new FrameworkPropertyMetadata(DataSourceDefault));

	public IEnumerable DataSource
	{
		get => (IEnumerable)GetValue(DataSourceProperty);
		set => SetValue(DataSourceProperty, value);
	}

	public static readonly DependencyProperty IsToolbarVisibleProperty = DependencyProperty.Register(
		nameof(IsToolbarVisible), typeof(bool), typeof(Chart3D), new FrameworkPropertyMetadata(IsToolbarVisibleDefault));

	public bool IsToolbarVisible
	{
		get => (bool)GetValue(IsToolbarVisibleProperty);
		set => SetValue(IsToolbarVisibleProperty, value);
	}

	public static readonly DependencyProperty IsScaleBarVisibleProperty = DependencyProperty.Register(
		nameof(IsScaleBarVisible), typeof(bool), typeof(Chart3D), new FrameworkPropertyMetadata(IsScaleBarVisibleDefault));

	public bool IsScaleBarVisible
	{
		get => (bool)GetValue(IsScaleBarVisibleProperty);
		set => SetValue(IsScaleBarVisibleProperty, value);
	}

	public static readonly DependencyProperty IsAxisVisibleProperty = DependencyProperty.Register(
		nameof(IsAxisVisible), typeof(bool), typeof(Chart3D), new FrameworkPropertyMetadata(IsAxisVisibleDefault));

	public bool IsAxisVisible
	{
		get => (bool)GetValue(IsAxisVisibleProperty);
		set => SetValue(IsAxisVisibleProperty, value);
	}

	public static readonly DependencyProperty AxisXLabelProperty = DependencyProperty.Register(
		nameof(AxisXLabel), typeof(string), typeof(Chart2D), new FrameworkPropertyMetadata(null));

	/// <summary>
	/// Set the label for the X-axis of the 3D chart
	/// 
	/// If null, uses application default of "X [nm]"
	/// </summary>
	public string? AxisXLabel
	{
		get => (string?)GetValue(AxisXLabelProperty);
		set => SetValue(AxisXLabelProperty, value);
	}

	public static readonly DependencyProperty AxisYLabelProperty = DependencyProperty.Register(
		nameof(AxisYLabel), typeof(string), typeof(Chart2D), new FrameworkPropertyMetadata(null));

	/// <summary>
	/// Set the label for the Y-axis of the 3D chart
	/// 
	/// If null, uses application default of "Y [nm]"
	/// </summary>
	public string? AxisYLabel
	{
		get => (string?)GetValue(AxisYLabelProperty);
		set => SetValue(AxisYLabelProperty, value);
	}

	public static readonly DependencyProperty AxisZLabelProperty = DependencyProperty.Register(
		nameof(AxisZLabel), typeof(string), typeof(Chart2D), new FrameworkPropertyMetadata(null));

	/// <summary>
	/// Set the label for the Z-axis of the 3D chart
	/// 
	/// If null, uses application default of "Z [nm]"
	/// </summary>
	public string? AxisZLabel
	{
		get => (string)GetValue(AxisZLabelProperty);
		set => SetValue(AxisZLabelProperty, value);
	}
}
