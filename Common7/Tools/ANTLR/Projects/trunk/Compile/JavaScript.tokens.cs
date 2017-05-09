public partial class JavaScriptLexer
{
	static void AddDynamicTokens() {
		DividePrecedingTokens.Add(111); // 'this'
		DividePrecedingTokens.Add(107); // '++'
		DividePrecedingTokens.Add(113); // 'true'
		DividePrecedingTokens.Add(55); // 'break'
		DividePrecedingTokens.Add(68); // ']'
		DividePrecedingTokens.Add(112); // 'null'
		DividePrecedingTokens.Add(106); // 'typeof'
		DividePrecedingTokens.Add(44); // ')'
		DividePrecedingTokens.Add(114); // 'false'
		DividePrecedingTokens.Add(108); // '--'
	}
}
