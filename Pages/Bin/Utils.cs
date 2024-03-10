public static class Utils {
	private static FormatException to_bool_exp;

	static Utils() {
		to_bool_exp = new FormatException();
	}

	public static string to_string(bool b) {
		if (b) return "true";
		else return "false";
	}
	public static bool to_bool(string s) {
		if (s=="true") return true;
		else if (s=="false") return false;
		else throw to_bool_exp;
	}
}