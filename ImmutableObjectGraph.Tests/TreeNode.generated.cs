﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace ImmutableObjectGraph.Tests {
	using System.Diagnostics;
	using System.Linq;
	using ImmutableObjectGraph;
	
	public partial class TreeNode : System.Collections.Generic.IEnumerable<TreeNode>, IRecursiveParentWithOrderedChildren, IRecursiveType {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly TreeNode DefaultInstance = GetDefaultTemplate();
		
		/// <summary>The last identity assigned to a created instance.</summary>
		private static int lastIdentityProduced;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String caption;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String filePath;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Boolean visible;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableHashSet<System.String> attributes;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<TreeNode> children;
	
		private readonly System.Int32 identity;
	
		/// <summary>Initializes a new instance of the TreeNode class.</summary>
		protected TreeNode(
			System.Int32 identity,
			System.String caption,
			System.String filePath,
			System.Boolean visible,
			System.Collections.Immutable.ImmutableHashSet<System.String> attributes,
			System.Collections.Immutable.ImmutableList<TreeNode> children,
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>>> lookupTable = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>>>))
		{
			this.identity = identity;
			this.caption = caption;
			this.filePath = filePath;
			this.visible = visible;
			this.attributes = attributes;
			this.children = children;
			this.Validate();
			this.InitializeLookup(lookupTable);
		}
	
		public static TreeNode Create(
			ImmutableObjectGraph.Optional<System.String> caption = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> filePath = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.Boolean> visible = default(ImmutableObjectGraph.Optional<System.Boolean>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>> attributes = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<TreeNode>> children = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<TreeNode>>)) {
			var identity = Optional.For(NewIdentity());
			return DefaultInstance.WithFactory(
				caption: Optional.For(caption.GetValueOrDefault(DefaultInstance.Caption)),
				filePath: Optional.For(filePath.GetValueOrDefault(DefaultInstance.FilePath)),
				visible: Optional.For(visible.GetValueOrDefault(DefaultInstance.Visible)),
				attributes: Optional.For(attributes.GetValueOrDefault(DefaultInstance.Attributes)),
				children: Optional.For(children.GetValueOrDefault(DefaultInstance.Children)),
				identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
	
		public System.String Caption {
			get { return this.caption; }
		}
	
		public System.String FilePath {
			get { return this.filePath; }
		}
	
		public System.Boolean Visible {
			get { return this.visible; }
		}
	
		public System.Collections.Immutable.ImmutableHashSet<System.String> Attributes {
			get { return this.attributes; }
		}
	
		public System.Collections.Immutable.ImmutableList<TreeNode> Children {
			get { return this.children; }
		}
		
		/// <summary>Returns a new instance with the Caption property set to the specified value.</summary>
		public TreeNode WithCaption(System.String value) {
			if (value == this.Caption) {
				return this;
			}
		
			return this.With(caption: Optional.For(value));
		}
		
		/// <summary>Returns a new instance with the FilePath property set to the specified value.</summary>
		public TreeNode WithFilePath(System.String value) {
			if (value == this.FilePath) {
				return this;
			}
		
			return this.With(filePath: Optional.For(value));
		}
		
		/// <summary>Returns a new instance with the Visible property set to the specified value.</summary>
		public TreeNode WithVisible(System.Boolean value) {
			if (value == this.Visible) {
				return this;
			}
		
			return this.With(visible: Optional.For(value));
		}
		
		/// <summary>Returns a new instance with the Attributes property set to the specified value.</summary>
		public TreeNode WithAttributes(System.Collections.Immutable.ImmutableHashSet<System.String> value) {
			if (value == this.Attributes) {
				return this;
			}
		
			return this.With(attributes: Optional.For(value));
		}
		
		/// <summary>Replaces the elements of the Attributes collection with the specified collection.</summary>
		public TreeNode WithAttributes(params System.String[] values) {
			return this.With(attributes: this.Attributes.ResetContents(values));
		}
		
		/// <summary>Replaces the elements of the Attributes collection with the specified collection.</summary>
		public TreeNode WithAttributes(System.Collections.Generic.IEnumerable<System.String> values) {
			return this.With(attributes: this.Attributes.ResetContents(values));
		}
		
		/// <summary>Adds the specified elements from the Attributes collection.</summary>
		public TreeNode AddAttributes(System.Collections.Generic.IEnumerable<System.String> values) {
			return this.With(attributes: this.Attributes.AddRange(values));
		}
		
		/// <summary>Adds the specified elements from the Attributes collection.</summary>
		public TreeNode AddAttributes(params System.String[] values) {
			return this.With(attributes: this.Attributes.AddRange(values));
		}
		
		/// <summary>Adds the specified element from the Attributes collection.</summary>
		public TreeNode AddAttribute(System.String value) {
			return this.With(attributes: this.Attributes.Add(value));
		}
		
		/// <summary>Removes the specified elements from the Attributes collection.</summary>
		public TreeNode RemoveAttributes(System.Collections.Generic.IEnumerable<System.String> values) {
			return this.With(attributes: this.Attributes.RemoveRange(values));
		}
		
		/// <summary>Removes the specified elements from the Attributes collection.</summary>
		public TreeNode RemoveAttributes(params System.String[] values) {
			return this.With(attributes: this.Attributes.RemoveRange(values));
		}
		
		/// <summary>Removes the specified element from the Attributes collection.</summary>
		public TreeNode RemoveAttribute(System.String value) {
			return this.With(attributes: this.Attributes.Remove(value));
		}
		
		/// <summary>Clears all elements from the Attributes collection.</summary>
		public TreeNode RemoveAttributes() {
			return this.With(attributes: this.Attributes.Clear());
		}
		
		
		/// <summary>Returns a new instance with the Children property set to the specified value.</summary>
		public TreeNode WithChildren(System.Collections.Immutable.ImmutableList<TreeNode> value) {
			if (value == this.Children) {
				return this;
			}
		
			return this.With(children: Optional.For(value));
		}
		
		/// <summary>Replaces the elements of the Children collection with the specified collection.</summary>
		public TreeNode WithChildren(params TreeNode[] values) {
			return this.With(children: this.Children.ResetContents(values));
		}
		
		/// <summary>Replaces the elements of the Children collection with the specified collection.</summary>
		public TreeNode WithChildren(System.Collections.Generic.IEnumerable<TreeNode> values) {
			return this.With(children: this.Children.ResetContents(values));
		}
		
		/// <summary>Adds the specified elements from the Children collection.</summary>
		public TreeNode AddChildren(System.Collections.Generic.IEnumerable<TreeNode> values) {
			return this.With(children: this.Children.AddRange(values));
		}
		
		/// <summary>Adds the specified elements from the Children collection.</summary>
		public TreeNode AddChildren(params TreeNode[] values) {
			return this.With(children: this.Children.AddRange(values));
		}
		
		/// <summary>Adds the specified element from the Children collection.</summary>
		public TreeNode AddChild(TreeNode value) {
			return this.With(children: this.Children.Add(value));
		}
		
		/// <summary>Removes the specified elements from the Children collection.</summary>
		public TreeNode RemoveChildren(System.Collections.Generic.IEnumerable<TreeNode> values) {
			return this.With(children: this.Children.RemoveRange(values.Select(v => this.SyncImmediateChildToCurrentVersion(v))));
		}
		
		/// <summary>Removes the specified elements from the Children collection.</summary>
		public TreeNode RemoveChildren(params TreeNode[] values) {
			return this.With(children: this.Children.RemoveRange(values.Select(v => this.SyncImmediateChildToCurrentVersion(v))));
		}
		
		/// <summary>Removes the specified element from the Children collection.</summary>
		public TreeNode RemoveChild(TreeNode value) {
			return this.With(children: this.Children.Remove(this.SyncImmediateChildToCurrentVersion(value)));
		}
		
		/// <summary>Clears all elements from the Children collection.</summary>
		public TreeNode RemoveChildren() {
			return this.With(children: this.Children.Clear());
		}
		
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public TreeNode With(
			ImmutableObjectGraph.Optional<System.String> caption = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> filePath = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.Boolean> visible = default(ImmutableObjectGraph.Optional<System.Boolean>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>> attributes = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<TreeNode>> children = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<TreeNode>>)) {
			return (TreeNode)this.WithCore(
				caption: caption,
				filePath: filePath,
				visible: visible,
				attributes: attributes,
				children: children);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		protected virtual TreeNode WithCore(
			ImmutableObjectGraph.Optional<System.String> caption = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> filePath = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.Boolean> visible = default(ImmutableObjectGraph.Optional<System.Boolean>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>> attributes = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<TreeNode>> children = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<TreeNode>>)) {
			var identity = default(ImmutableObjectGraph.Optional<System.Int32>);
			return this.WithFactory(
				caption: Optional.For(caption.GetValueOrDefault(this.Caption)),
				filePath: Optional.For(filePath.GetValueOrDefault(this.FilePath)),
				visible: Optional.For(visible.GetValueOrDefault(this.Visible)),
				attributes: Optional.For(attributes.GetValueOrDefault(this.Attributes)),
				children: Optional.For(children.GetValueOrDefault(this.Children)),
				identity: Optional.For(identity.GetValueOrDefault(this.Identity)));
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		private TreeNode WithFactory(
			ImmutableObjectGraph.Optional<System.String> caption = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> filePath = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.Boolean> visible = default(ImmutableObjectGraph.Optional<System.Boolean>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>> attributes = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<TreeNode>> children = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<TreeNode>>),
			ImmutableObjectGraph.Optional<System.Int32> identity = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(identity.IsDefined && identity.Value != this.Identity) || 
				(caption.IsDefined && caption.Value != this.Caption) || 
				(filePath.IsDefined && filePath.Value != this.FilePath) || 
				(visible.IsDefined && visible.Value != this.Visible) || 
				(attributes.IsDefined && attributes.Value != this.Attributes) || 
				(children.IsDefined && children.Value != this.Children)) {
				var lookupTable = children.IsDefined && children.Value != this.Children ? default(Optional<System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>>>) : Optional.For(this.lookupTable);
				return new TreeNode(
					identity: identity.GetValueOrDefault(this.Identity),
					caption: caption.GetValueOrDefault(this.Caption),
					filePath: filePath.GetValueOrDefault(this.FilePath),
					visible: visible.GetValueOrDefault(this.Visible),
					attributes: attributes.GetValueOrDefault(this.Attributes),
					children: children.GetValueOrDefault(this.Children),
					lookupTable: lookupTable);
			} else {
				return this;
			}
		}
	
		protected internal System.Int32 Identity {
			get { return this.identity; }
		}
	
		/// <summary>Returns a unique identity that may be assigned to a newly created instance.</summary>
		protected static System.Int32 NewIdentity() {
			return System.Threading.Interlocked.Increment(ref lastIdentityProduced);
		}
	
		public System.Collections.Generic.IEnumerator<TreeNode> GetEnumerator() {
			return this.children.GetEnumerator();
		}
	
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return this.children.GetEnumerator();
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated TreeNode whose fields are initialized with default values.</summary>
		private static TreeNode GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new TreeNode(
				default(System.Int32), 
				template.Caption, 
				template.FilePath, 
				template.Visible, 
				template.Attributes, 
				template.Children);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String Caption { get; set; }
	
			internal System.String FilePath { get; set; }
	
			internal System.Boolean Visible { get; set; }
	
			internal System.Collections.Immutable.ImmutableHashSet<System.String> Attributes { get; set; }
	
			internal System.Collections.Immutable.ImmutableList<TreeNode> Children { get; set; }
		}
		
		protected TreeNode SyncImmediateChildToCurrentVersion(TreeNode child) {
			TreeNode currentValue;
			if (!this.TryFindImmediateChild(child.Identity, out currentValue)) {
				throw new System.ArgumentException();
			}
		
			return currentValue;
		}
		
		public TreeNode AddDescendent(TreeNode value, TreeNode parent) {
			var spine = this.GetSpine(parent);
			var newParent = parent.AddChildren(value);
			var newSpine = System.Collections.Immutable.ImmutableStack.Create(value, newParent);
			return (TreeNode)this.ReplaceDescendent(spine, newSpine, spineIncludesDeletedElement: false).Peek();
		}
		
		public TreeNode RemoveDescendent(TreeNode value) {
			var spine = this.GetSpine(value);
			var spineList = spine.ToList();
			var parent = (TreeNode)spineList[spineList.Count - 2];
			var newParent = parent.RemoveChildren(spineList[spineList.Count - 1]);
		
			var newSpine = System.Collections.Immutable.ImmutableStack.Create((TreeNode)newParent);
			return (TreeNode)this.ReplaceDescendent(spine, newSpine, spineIncludesDeletedElement: true).Peek();
		}
		
		public TreeNode ReplaceDescendent(TreeNode current, TreeNode replacement) {
			var spine = this.GetSpine(current);
		
			if (spine.IsEmpty) {
				// The descendent was not found.
				throw new System.ArgumentException("Old value not found");
			}
		
			return (TreeNode)this.ReplaceDescendent(spine, System.Collections.Immutable.ImmutableStack.Create(replacement), spineIncludesDeletedElement: false).Peek();
		}
		
		private System.Collections.Immutable.ImmutableStack<TreeNode> ReplaceDescendent(System.Collections.Immutable.ImmutableStack<TreeNode> spine, System.Collections.Immutable.ImmutableStack<TreeNode> replacementStackTip, bool spineIncludesDeletedElement) {
			Debug.Assert(this == spine.Peek());
			var remainingSpine = spine.Pop();
			if (remainingSpine.IsEmpty || (spineIncludesDeletedElement && remainingSpine.Pop().IsEmpty)) {
				// This is the instance to be changed.
				return replacementStackTip;
			}
		
			System.Collections.Immutable.ImmutableStack<TreeNode> newChildSpine;
			var child = remainingSpine.Peek();
			var recursiveChild = child as TreeNode;
			if (recursiveChild != null) {
				newChildSpine = recursiveChild.ReplaceDescendent(remainingSpine, replacementStackTip, spineIncludesDeletedElement);
			} else {
				Debug.Assert(remainingSpine.Pop().IsEmpty); // we should be at the tail of the stack, since we're at a leaf.
				Debug.Assert(this.Children.Contains(child));
				newChildSpine = replacementStackTip;
			}
		
			var newChildren = this.Children.Replace(child, newChildSpine.Peek());
			var newSelf = this.WithChildren(newChildren);
			if (newSelf.lookupTable == lookupTableLazySentinal && this.lookupTable != null && this.lookupTable != lookupTableLazySentinal) {
				// Our newly mutated self wants a lookup table. If we already have one we can use it,
				// but it needs to be fixed up given the newly rewritten spine through our descendents.
				newSelf.lookupTable = this.FixupLookupTable(ImmutableDeque.Create(newChildSpine), ImmutableDeque.Create(remainingSpine));
				newSelf.ValidateInternalIntegrityDebugOnly();
			}
		
			return newChildSpine.Push(newSelf);
		}
		
		/// <summary>
		/// Produces a fast lookup table based on an existing one, if this node has one, to account for an updated spine among its descendents.
		/// </summary>
		/// <param name="updatedSpine">
		/// The spine of this node's new descendents' instances that are created for this change.
		/// The head is an immediate child of the new instance for this node.
		/// The tail is the node that was added or replaced.
		/// </param>
		/// <param name="oldSpine">
		/// The spine of this node's descendents that have been changed in this delta.
		/// The head is an immediate child of this instance.
		/// The tail is the node that was removed or replaced.
		/// </param>
		/// <returns>An updated lookup table.</returns>
		private System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>> FixupLookupTable(ImmutableObjectGraph.ImmutableDeque<TreeNode> updatedSpine, ImmutableObjectGraph.ImmutableDeque<TreeNode> oldSpine) {
			if (this.lookupTable == null || this.lookupTable == lookupTableLazySentinal) {
				// We don't already have a lookup table to base this on, so leave it to the new instance to lazily construct.
				return lookupTableLazySentinal;
			}
		
			if ((updatedSpine.IsEmpty && oldSpine.IsEmpty) ||
				(updatedSpine.Count > 1 && oldSpine.Count > 1 && System.Object.ReferenceEquals(updatedSpine.PeekHead(), oldSpine.PeekHead()))) {
				// No changes were actually made.
				return this.lookupTable;
			}
		
			var lookupTable = this.lookupTable.ToBuilder();
		
			// Classify the kind of change that has just occurred.
			var oldSpineTail = oldSpine.PeekTail();
			var newSpineTail = updatedSpine.PeekTail();
			ChangeKind changeKind;
			bool childrenChanged = false;
			if (updatedSpine.Count == oldSpine.Count) {
				changeKind = ChangeKind.Replaced;
				var oldSpineTailRecursive = oldSpineTail as TreeNode;
				var newSpineTailRecursive = newSpineTail as TreeNode;
				if (oldSpineTailRecursive != null || newSpineTailRecursive != null) {
					// Children have changed if either before or after type didn't have a children property,
					// or if both did, but the children actually changed.
					childrenChanged = oldSpineTailRecursive == null || newSpineTailRecursive == null
						|| !System.Object.ReferenceEquals(oldSpineTailRecursive.Children, newSpineTailRecursive.Children);
				}
			} else if (updatedSpine.Count > oldSpine.Count) {
				changeKind = ChangeKind.Added;
			} else // updatedSpine.Count < oldSpine.Count
			{
				changeKind = ChangeKind.Removed;
			}
		
			// Trim the lookup table of any entries for nodes that have been removed from the tree.
			if (childrenChanged || changeKind == ChangeKind.Removed) {
				// We need to remove all descendents of the old tail node.
				lookupTable.RemoveRange(oldSpineTail.GetSelfAndDescendents().Select(n => n.Identity));
			} else if (changeKind == ChangeKind.Replaced && oldSpineTail.Identity != newSpineTail.Identity) {
				// The identity of the node was changed during the replacement.  We must explicitly remove the old entry
				// from our lookup table in this case.
				lookupTable.Remove(oldSpineTail.Identity);
		
				// We also need to update any immediate children of the old spine tail
				// because the identity of their parent has changed.
				var oldSpineTailRecursive = oldSpineTail as TreeNode;
				if (oldSpineTailRecursive != null) {
					foreach (var child in oldSpineTailRecursive) {
						lookupTable[child.Identity] = new System.Collections.Generic.KeyValuePair<TreeNode, int>(child, newSpineTail.Identity);
					}
				}
			}
		
			// Update our lookup table so that it includes (updated) entries for every member of the spine itself.
			TreeNode parent = this;
			foreach (var node in updatedSpine) {
				// Remove and add rather than use the Set method, since the old and new node are equal (in identity) therefore the map class will
				// assume no change is relevant and not apply the change.
				lookupTable.Remove(node.Identity);
				lookupTable.Add(node.Identity, new System.Collections.Generic.KeyValuePair<TreeNode, int>(node, parent.Identity));
				parent = node;
			}
		
			// There may be children on the added node that we should include.
			if (childrenChanged || changeKind == ChangeKind.Added) {
				var recursiveParent = parent as TreeNode;
				if (recursiveParent != null) {
					recursiveParent.ContributeDescendentsToLookupTable(lookupTable);
				}
			}
		
			return lookupTable.ToImmutable();
		}
		
		/// <summary>
		/// Validates this node and all its descendents <em>only in DEBUG builds</em>.
		/// </summary>
		[Conditional("DEBUG")]
		private void ValidateInternalIntegrityDebugOnly() {
			this.ValidateInternalIntegrity();
		}
		
		/// <summary>
		/// Validates this node and all its descendents.
		/// </summary>
		protected internal void ValidateInternalIntegrity() {
			// Each node id appears at most once.
			var observedIdentities = new System.Collections.Generic.HashSet<int>();
			foreach (var node in this.GetSelfAndDescendents()) {
				if (!observedIdentities.Add(node.Identity)) {
					throw new RecursiveChildNotUniqueException(node.Identity);
				}
			}
		
			// The lookup table (if any) accurately describes the contents of this tree.
			if (this.lookupTable != null && this.lookupTable != lookupTableLazySentinal) {
				// The table should have one entry for every *descendent* of this node (not this node itself).
				int expectedCount = this.GetSelfAndDescendents().Count() - 1;
				int actualCount = this.lookupTable.Count;
				if (actualCount != expectedCount) {
					throw new System.ApplicationException(string.Format(System.Globalization.CultureInfo.CurrentCulture, "Expected {0} entries in lookup table but found {1}.", expectedCount, actualCount));
				}
		
				this.ValidateLookupTable(this.lookupTable);
			}
		}
		
		/// <summary>
		/// Validates that the contents of a lookup table are valid for all descendent nodes of this node.
		/// </summary>
		/// <param name="lookupTable">The lookup table being validated.</param>
		private void ValidateLookupTable(System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>> lookupTable) {
			const string ErrorString = "Lookup table integrity failure.";
		
			foreach (var child in this.Children) {
				var entry = lookupTable[child.Identity];
				if (!object.ReferenceEquals(entry.Key, child)) {
					throw new System.ApplicationException(ErrorString);
				}
		
				if (entry.Value != this.Identity) {
					throw new System.ApplicationException(ErrorString);
				}
		
				var recursiveChild = child as TreeNode;
				if (recursiveChild != null) {
					recursiveChild.ValidateLookupTable(lookupTable);
				}
			}
		}
		
		private static readonly System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>> lookupTableLazySentinal = System.Collections.Immutable.ImmutableDictionary.Create<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>>().Add(default(System.Int32), new System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>());
		
		private System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>> lookupTable;
		
		private int inefficiencyLoad;
		
		/// <summary>
		/// The maximum number of steps allowable for a search to be done among this node's children
		/// before a faster lookup table will be built.
		/// </summary>
		internal const int InefficiencyLoadThreshold = 16;
		
		private System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>> LookupTable {
			get {
				if (this.lookupTable == lookupTableLazySentinal) {
					this.lookupTable = this.CreateLookupTable();
					this.inefficiencyLoad = 1;
				}
		
				return this.lookupTable;
			}
		}
		
		private void InitializeLookup(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>>> priorLookupTable = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>>>)) {
			this.inefficiencyLoad = 1;
			if (priorLookupTable.IsDefined && priorLookupTable.Value != null) {
				this.lookupTable = priorLookupTable.Value;
			} else {
				if (this.children != null) {
					foreach (var child in this.children)
					{
						var recursiveChild = child as TreeNode;
						this.inefficiencyLoad += recursiveChild != null ? recursiveChild.inefficiencyLoad : 1;
					}
				}
		
				if (this.inefficiencyLoad > InefficiencyLoadThreshold) {
					this.inefficiencyLoad = 1;
					this.lookupTable = lookupTableLazySentinal;
				}
			}
		
			this.ValidateInternalIntegrityDebugOnly();
		}
		
		/// <summary>
		/// Creates the lookup table that will contain all this node's children.
		/// </summary>
		/// <returns>The lookup table.</returns>
		private System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>> CreateLookupTable() {
			var table = System.Collections.Immutable.ImmutableDictionary.Create<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>>().ToBuilder();
			this.ContributeDescendentsToLookupTable(table);
			return table.ToImmutable();
		}
		
		/// <summary>
		/// Adds this node's children (recursively) to the lookup table.
		/// </summary>
		/// <param name="seedLookupTable">The lookup table to add entries to.</param>
		/// <returns>The new lookup table.</returns>
		private void ContributeDescendentsToLookupTable(System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>>.Builder seedLookupTable)
		{
			foreach (var child in this.Children)
			{
				seedLookupTable.Add(child.Identity, new System.Collections.Generic.KeyValuePair<TreeNode, System.Int32>(child, this.Identity));
				var recursiveChild = child as TreeNode;
				if (recursiveChild != null) {
					recursiveChild.ContributeDescendentsToLookupTable(seedLookupTable);
				}
			}
		}
		
		public bool TryFind(System.Int32 identity, out TreeNode value) {
			if (this.Identity.Equals(identity)) {
				value = this;
				return true;
			}
		
			if (this.LookupTable != null) {
				System.Collections.Generic.KeyValuePair<TreeNode, System.Int32> lookupValue;
				if (this.LookupTable.TryGetValue(identity, out lookupValue)) {
					value = lookupValue.Key;
					return true;
				}
			} else {
				// No lookup table means we have to exhaustively search each child and its descendents.
				foreach (var child in this.Children) {
					var recursiveChild = child as TreeNode;
					if (recursiveChild != null) {
						if (recursiveChild.TryFind(identity, out value)) {
							return true;
						}
					} else {
						if (child.Identity.Equals(identity)) {
							value = child;
							return true;
						}
					}
				}
			}
		
			value = null;
			return false;
		}
		
		public TreeNode Find(System.Int32 identity) {
			TreeNode result;
			if (this.TryFind(identity, out result)) {
				return result;
			}
		
			throw new System.Collections.Generic.KeyNotFoundException();
		}
		
		public bool TryFindImmediateChild(System.Int32 identity, out TreeNode value) {
			if (this.LookupTable != null) {
				System.Collections.Generic.KeyValuePair<TreeNode, System.Int32> lookupValue;
				if (this.LookupTable.TryGetValue(identity, out lookupValue) && lookupValue.Value == this.Identity) {
					value = lookupValue.Key;
					return true;
				}
			} else {
				// No lookup table means we have to exhaustively search each child.
				foreach (var child in this.Children) {
					if (child.Identity.Equals(identity)) {
						value = child;
						return true;
					}
				}
			}
		
			value = null;
			return false;
		}
		
		/// <summary>Checks whether an object with the specified identity is among this object's descendents.</summary>
		public bool Contains(System.Int32 identity) {
			TreeNode result;
			return this.TryFind(identity, out result) && result != this;
		}
		
		/// <summary>Gets the recursive parent of the specified value, or <c>null</c> if none could be found.</summary>
		internal ParentedRecursiveType<TreeNode, TreeNode> GetParentedNode(System.Int32 identity) {
			if (this.Identity == identity) {
				return new ParentedRecursiveType<TreeNode, TreeNode>(this, null);
			}
		
			if (this.LookupTable != null) {
				System.Collections.Generic.KeyValuePair<TreeNode, System.Int32> lookupValue;
				if (this.LookupTable.TryGetValue(identity, out lookupValue)) {
					var parentIdentity = lookupValue.Value;
					return new ParentedRecursiveType<TreeNode, TreeNode>(this.LookupTable[identity].Key, (TreeNode)this.Find(parentIdentity));
				}
			} else {
				// No lookup table means we have to aggressively search each child.
				foreach (var child in this.Children) {
					if (child.Identity.Equals(identity)) {
						return new ParentedRecursiveType<TreeNode, TreeNode>(child, this);
					}
		
					var recursiveChild = child as TreeNode;
					if (recursiveChild != null) {
						var childResult = recursiveChild.GetParentedNode(identity);
						if (childResult.Value != null) {
							return childResult;
						}
					} 
				}
			}
		
			return default(ParentedRecursiveType<TreeNode, TreeNode>);
		}
		
		/// <summary>Gets the recursive parent of the specified value, or <c>null</c> if none could be found.</summary>
		internal TreeNode GetParent(TreeNode descendent) {
			return this.GetParentedNode(descendent.Identity).Parent;
		}
		
		public System.Collections.Immutable.ImmutableStack<TreeNode> GetSpine(System.Int32 descendent) {
			var emptySpine = System.Collections.Immutable.ImmutableStack.Create<TreeNode>();
			if (this.Identity.Equals(descendent)) {
				return emptySpine.Push(this);
			}
		
			if (this.LookupTable != null) {
				System.Collections.Generic.KeyValuePair<TreeNode, System.Int32> lookupValue;
				if (this.LookupTable.TryGetValue(descendent, out lookupValue))
				{
					// Awesome.  We know the node the caller is looking for is a descendent of this node.
					// Now just string together all the nodes that connect this one with the sought one.
					var spine = emptySpine;
					do
					{
						spine = spine.Push(lookupValue.Key);
					}
					while (this.lookupTable.TryGetValue(lookupValue.Value, out lookupValue));
					return spine.Push(this);
				}
			} else {
				// We don't have an efficient lookup table for this node.  Aggressively search every child.
				var spine = emptySpine;
				foreach (var child in this.Children) {
					var recursiveChild = child as TreeNode;
					if (recursiveChild != null) {
						spine = recursiveChild.GetSpine(descendent);
					} else if (child.Identity.Equals(descendent)) {
						spine = spine.Push(child);
					}
		
					if (!spine.IsEmpty) {
						return spine.Push(this);
					}
				}
			}
		
			// The descendent is not in this sub-tree.
			return emptySpine;
		}
		
		public System.Collections.Immutable.ImmutableStack<TreeNode> GetSpine(TreeNode descendent) {
			return this.GetSpine(descendent.Identity);
		}
	
		System.Collections.Generic.IEnumerable<IRecursiveType> IRecursiveParent.Children {
			get { return this.Children; }
		}
	
		ParentedRecursiveType<IRecursiveParent, IRecursiveType> IRecursiveParent.GetParentedNode(int identity) {
			var parented = this.GetParentedNode(identity);
			return new ParentedRecursiveType<IRecursiveParent, IRecursiveType>(parented.Value, parented.Parent);
		}
		int IRecursiveParentWithOrderedChildren.IndexOf(IRecursiveType value) {
			return this.Children.IndexOf((TreeNode)value);
		}
	
		int IRecursiveType.Identity {
			get { return this.Identity; }
		}
	}
}


