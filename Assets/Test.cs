using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {


	void Start () {

		// 以下、課題です------------------------------------

		// 配列を宣言して初期化
		int[] array = {23, 5, 17, 38, 9};

		// 配列を順番に表示
		Debug.Log (array [0]);
		Debug.Log (array [1]);
		Debug.Log (array [2]);
		Debug.Log (array [3]);
		Debug.Log (array [4]);

		// 配列を逆順に表示
		for(int i = array.Length - 1; i >= 0; i--){
			Debug.Log (array [i]);
		}

		// 以下、発展課題です--------------------------------

		// インスタンス生成
		Boss battle = new Boss ();
		// Magic関数を11回呼び出し
		for (int j = 0; j < 11; j++) {
			battle.Magic ();
		}
	
	}

}


// Bossクラス
public class Boss{

	// メンバ変数mp
	int mp = 53;

	// Magic関数
	public void Magic(){

		if(this.mp < 5){
			Debug.Log("MPが足りないため魔法が使えない");
		}else{
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
		}

	}

}
