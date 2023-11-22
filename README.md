# ChokomakaComponents

## About

UI等の細かいComponentを作ってはコンパイル、作ってはコンパイル...
が面倒なので、ある程度簡単な仕様をまとめたものになります。

## Usage

※制作中なので、現時点での利用は推奨しません。すぐに仕様が変更される場合があります。いや、されます。
DOTweenを前提としているため、現時点ではClone→DOTweenのEditorからCreate Assemblyする→ChokomakaのAssemblyの参照に`DOTween.Modules`を入れることによってはじめて使用できます。

## Prefab

Runtime/Assets/Prefabsにてよく使うUIのPrefabを用意しております。
Componentの見た目等を調整すると、自動で/ImplsのPrefabにも反映されます（/ImplsのPrefabはすべてPrefab Variantです）。

## 前提ライブラリ

- UniRx
- UniTask
- DOTween
- LucidAudio
