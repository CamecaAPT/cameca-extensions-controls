using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Cameca.Extensions.Controls;

public class PropertyGrid : Control
{
	public static readonly object? SelectedObjectDefault = null;
	public static readonly IEnumerable SelectedObjectsDefault = Enumerable.Empty<object>();
	public static readonly Visibility ExpandButtonsVisibilityDefault = Visibility.Hidden;
	public static readonly bool ExpandCategoriesWhenSelectedObjectChangedDefault = true;
	public static readonly bool ShowCategoriesDefault = true;
	public static readonly bool ShowEditorButtonsDefault = false;
	public static readonly bool ShowSearchBoxDefault = false;
	public static readonly bool ShowToolPanelDefault = false;

	public static readonly DependencyProperty SelectedObjectProperty = DependencyProperty.Register(
		nameof(SelectedObject), typeof(object), typeof(PropertyGrid), new FrameworkPropertyMetadata(SelectedObjectDefault) { BindsTwoWayByDefault = true, });

	public object? SelectedObject
	{
		get => (object?)GetValue(SelectedObjectProperty);
		set => SetValue(SelectedObjectProperty, value);
	}

	public static readonly DependencyProperty SelectedObjectsProperty = DependencyProperty.Register(
		nameof(SelectedObjects), typeof(IEnumerable), typeof(Table), new FrameworkPropertyMetadata(SelectedObjectsDefault) { BindsTwoWayByDefault = true, });

	public IEnumerable SelectedObjects
	{
		get => (IEnumerable)GetValue(SelectedObjectsProperty);
		set => SetValue(SelectedObjectsProperty, value);
	}

	public static readonly DependencyProperty ExpandButtonsVisibilityProperty = DependencyProperty.Register(
		nameof(ExpandButtonsVisibility), typeof(Visibility), typeof(PropertyGrid), new FrameworkPropertyMetadata(ExpandButtonsVisibilityDefault) { BindsTwoWayByDefault = true, });

	public Visibility ExpandButtonsVisibility
	{
		get => (Visibility)GetValue(ExpandButtonsVisibilityProperty);
		set => SetValue(ExpandButtonsVisibilityProperty, value);
	}

	public static readonly DependencyProperty ExpandCategoriesWhenSelectedObjectChangedProperty = DependencyProperty.Register(
		nameof(ExpandCategoriesWhenSelectedObjectChanged), typeof(bool), typeof(PropertyGrid), new FrameworkPropertyMetadata(ExpandCategoriesWhenSelectedObjectChangedDefault) { BindsTwoWayByDefault = true, });

	public bool ExpandCategoriesWhenSelectedObjectChanged
	{
		get => (bool)GetValue(ExpandCategoriesWhenSelectedObjectChangedProperty);
		set => SetValue(ExpandCategoriesWhenSelectedObjectChangedProperty, value);
	}

	public static readonly DependencyProperty ShowCategoriesProperty = DependencyProperty.Register(
		nameof(ShowCategories), typeof(bool), typeof(PropertyGrid), new FrameworkPropertyMetadata(ShowCategoriesDefault) { BindsTwoWayByDefault = true, });

	public bool ShowCategories
	{
		get => (bool)GetValue(ShowCategoriesProperty);
		set => SetValue(ShowCategoriesProperty, value);
	}

	public static readonly DependencyProperty ShowEditorButtonsProperty = DependencyProperty.Register(
		nameof(ShowEditorButtons), typeof(bool), typeof(PropertyGrid), new FrameworkPropertyMetadata(ShowEditorButtonsDefault) { BindsTwoWayByDefault = true, });

	public bool ShowEditorButtons
	{
		get => (bool)GetValue(ShowEditorButtonsProperty);
		set => SetValue(ShowEditorButtonsProperty, value);
	}

	public static readonly DependencyProperty ShowSearchBoxProperty = DependencyProperty.Register(
		nameof(ShowSearchBox), typeof(bool), typeof(PropertyGrid), new FrameworkPropertyMetadata(ShowSearchBoxDefault) { BindsTwoWayByDefault = true, });

	public bool ShowSearchBox
	{
		get => (bool)GetValue(ShowSearchBoxProperty);
		set => SetValue(ShowSearchBoxProperty, value);
	}

	public static readonly DependencyProperty ShowToolPanelProperty = DependencyProperty.Register(
		nameof(ShowToolPanel), typeof(bool), typeof(PropertyGrid), new FrameworkPropertyMetadata(ShowToolPanelDefault) { BindsTwoWayByDefault = true, });

	public bool ShowToolPanel
	{
		get => (bool)GetValue(ShowToolPanelProperty);
		set => SetValue(ShowToolPanelProperty, value);
	}
}
