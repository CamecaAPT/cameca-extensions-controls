using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Cameca.Extensions.Controls;

public class PropertyGrid : Control
{
	private static readonly object? SelectedObjectDefault = null;
	private static readonly IEnumerable SelectedObjectsDefault = Enumerable.Empty<object>();
	private static readonly Visibility ExpandButtonsVisibilityDefault = Visibility.Hidden;
	private static readonly bool ExpandCategoriesWhenSelectedObjectChangedDefault = true;
	private static readonly bool ShowCategoriesDefault = true;
	private static readonly bool ShowEditorButtonsDefault = false;
	private static readonly bool ShowSearchBoxDefault = false;
	private static readonly bool ShowToolPanelDefault = false;

	public static readonly DependencyProperty SelectedObjectProperty = DependencyProperty.Register(
		nameof(SelectedObject), typeof(object), typeof(PropertyGrid), new PropertyMetadata(SelectedObjectDefault));

	public object? SelectedObject
	{
		get => (object?)GetValue(SelectedObjectProperty);
		set => SetValue(SelectedObjectProperty, value);
	}

	public static readonly DependencyProperty SelectedObjectsProperty = DependencyProperty.Register(
		nameof(SelectedObjects), typeof(IEnumerable), typeof(Table), new PropertyMetadata(SelectedObjectsDefault));

	public IEnumerable SelectedObjects
	{
		get => (IEnumerable)GetValue(SelectedObjectsProperty);
		set => SetValue(SelectedObjectsProperty, value);
	}

	public static readonly DependencyProperty ExpandButtonsVisibilityProperty = DependencyProperty.Register(
		nameof(ExpandButtonsVisibility), typeof(Visibility), typeof(PropertyGrid), new PropertyMetadata(ExpandButtonsVisibilityDefault));

	public Visibility ExpandButtonsVisibility
	{
		get => (Visibility)GetValue(ExpandButtonsVisibilityProperty);
		set => SetValue(ExpandButtonsVisibilityProperty, value);
	}

	public static readonly DependencyProperty ExpandCategoriesWhenSelectedObjectChangedProperty = DependencyProperty.Register(
		nameof(ExpandCategoriesWhenSelectedObjectChanged), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(ExpandCategoriesWhenSelectedObjectChangedDefault));

	public bool ExpandCategoriesWhenSelectedObjectChanged
	{
		get => (bool)GetValue(ExpandCategoriesWhenSelectedObjectChangedProperty);
		set => SetValue(ExpandCategoriesWhenSelectedObjectChangedProperty, value);
	}

	public static readonly DependencyProperty ShowCategoriesProperty = DependencyProperty.Register(
		nameof(ShowCategories), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(ShowCategoriesDefault));

	public bool ShowCategories
	{
		get => (bool)GetValue(ShowCategoriesProperty);
		set => SetValue(ShowCategoriesProperty, value);
	}

	public static readonly DependencyProperty ShowEditorButtonsProperty = DependencyProperty.Register(
		nameof(ShowEditorButtons), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(ShowEditorButtonsDefault));

	public bool ShowEditorButtons
	{
		get => (bool)GetValue(ShowEditorButtonsProperty);
		set => SetValue(ShowEditorButtonsProperty, value);
	}

	public static readonly DependencyProperty ShowSearchBoxProperty = DependencyProperty.Register(
		nameof(ShowSearchBox), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(ShowSearchBoxDefault));

	public bool ShowSearchBox
	{
		get => (bool)GetValue(ShowSearchBoxProperty);
		set => SetValue(ShowSearchBoxProperty, value);
	}

	public static readonly DependencyProperty ShowToolPanelProperty = DependencyProperty.Register(
		nameof(ShowToolPanel), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(ShowToolPanelDefault));

	public bool ShowToolPanel
	{
		get => (bool)GetValue(ShowToolPanelProperty);
		set => SetValue(ShowToolPanelProperty, value);
	}
}
