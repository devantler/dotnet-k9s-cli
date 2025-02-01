using System.Runtime.Serialization;

namespace Devantler.K9sCLI;

/// <summary>
/// The editor to use for viewing files while debugging.
/// </summary>
public enum Editor
{
  /// <summary>
  /// Nano
  /// </summary>
  [EnumMember(Value = "/usr/bin/nano")]
  Nano,

  /// <summary>
  /// Vim
  /// </summary>
  [EnumMember(Value = "/usr/bin/vim")]
  Vim
}
