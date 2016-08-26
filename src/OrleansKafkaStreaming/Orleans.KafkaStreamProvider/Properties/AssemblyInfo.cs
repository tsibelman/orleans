using Orleans.CodeGeneration;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Orleans.KafkaStreamProvider")]
[assembly: AssemblyDescription("An Orleans PersistentStreamProvider based on Kafka")]
[assembly: AssemblyConfiguration("")]


// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e9e1ab55-c19f-4c48-a8c9-a32611714aa0")]

[assembly: InternalsVisibleTo("UnitTests")]
[assembly: InternalsVisibleTo("TesterInternal")]
[assembly: InternalsVisibleTo("UnitTestGrains")]
[assembly: SkipCodeGeneration]