using static Utils;

public static class conf {
	private static Dictionary<string,string> config = new Dictionary<string,string>();

	static conf() {
		config.Add("WE_FOOTER_TEXT","算法学习站");
	}

	public static void set(string k,string v) {
		if (config.ContainsKey(k)) {
			config[k] = v;
		} else {
			config.Add(k,v);
		}
	}

	public static void set(string k,bool v) {
		if (config.ContainsKey(k)) {
			config[k] = to_string(v);
		} else {
			config.Add(k,to_string(v));
		}
	}

	public static void get(string k,out string ret) {
		if (config.ContainsKey(k)) ret = config[k];
		else ret = "";
	}

	public static void get(string k,out bool ret) {
		if (config.ContainsKey(k)) ret = to_bool(config[k]);
		else ret = false;
	}
}