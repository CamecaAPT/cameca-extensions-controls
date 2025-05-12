using System;
using System.ComponentModel;

namespace Cameca.Extensions.Controls;

[Obsolete("Projection will not be editable in future versions for better application compatibility. Remove Projection configuration and use default projection of XZ")]
[EditorBrowsable(EditorBrowsableState.Never)]
/// <summary>
/// 2D projections.
/// </summary>
public enum Projection2D
{
	/// <summary>X - horizontal, Y - vertical.</summary>
	XY = 0,
	/// <summary>X - horizontal, Z - vertical.</summary>
	XZ = 1,
	/// <summary>Y - horizontal, X - vertical.</summary>
	YX = 2,
	/// <summary>Y - horizontal, Z - vertical.</summary>
	YZ = 3,
	/// <summary>Z - horizontal, X - vertical.</summary>
	ZX = 4,
	/// <summary>Z - horizontal, Y - vertical.</summary>
	ZY = 5,
}
