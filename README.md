# photon-template-plugin

こちらは、Photon 公式の[ドキュメント](https://doc.photonengine.com/ja-jp/server/current/plugins/getting-started)に沿って作成したテンプレートプラグインです。

## バージョン

- Server Plugin SDK: v5-0-12-24499-rc1

## 修正点

### ゲームサーバー認証設定

Photon Javascripot SDK v4-1-1-0 ではゲームサーバーの認証に関して不具合があるため、その対応として`deploy\LoadBalancing\GameServer\bin\GameServer.xml.config`を編集しています。

Before

```
      <WorkloadConfigFile>Workload.1Gbps.config</WorkloadConfigFile>
    </GameServer>
```

After

```
      <WorkloadConfigFile>Workload.1Gbps.config</WorkloadConfigFile>
      <TokenCheckExpectedHostAndGame>false</TokenCheckExpectedHostAndGame>
    </GameServer>
```

### 対象プラットフォーム設定

PhotonHivePlugin.dll が AMD64 を前提にしているため、対象プラットフォームを x64 に設定しています。

※この設定を行わないと、NUnit を使用した際にテストが実行できないという不具合が発生することを確認しています。

## 使い方

1. プロジェクトをコピー
2. ソリューションを編集
3. ライセンスをコピー
4. プラグインを起動

### プロジェクトをコピー

プロジェクトルートにあるフォルダを全てコピーしてください。こちらのプロジェクトには Photon Server の実行環境とプラグインプロジェクトが含まれています。

### ソリューションを編集

`src-server\Plugins\TemplatePlugin`がプラグインのソリューションが含まれているフォルダです。
それぞれのプロジェクト名に合わせて以下をリネームしてください。

- ソリューション名
- プロジェクト名
- ソース名
- 名前空間
- プロジェクト設定
  - アセンブリ名
  - 既定の名前空間
- プラグイン設定
  - `deploy\LoadBalancing\GameServer\bin\plugin.config`

### ライセンスをコピー

Photon のダッシュボードからライセンスを作成し、ダウンロードした.license ファイルを`deploy\bin_Win64`以下にコピーしてください。

### プラグインを起動

Visual Studio ソリューションをデバッグ実行すると、サーバーが起動します。
