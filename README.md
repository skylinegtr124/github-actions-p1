В этом проекте происходит обучение github actions.
Добавлен проект простого веб-сервера на C#. Создали CI (Build) для проверки, что проект вообще скомпилируется.
CD выполнен как копирование файлов проекта через rsync на продакшн сервер (через ssh port forward), позже будет компиляция проекта и отправка уже готовых бинарников, а дальше автоматическая контейнеризация (скорее всего пересоздание контейнера через docker compose).

  Last Deployment:<br>
  <img src="https://github.com/skylinegtr124/github-actions-p1/actions/workflows/pipeline1.yml/badge.svg"><br>

  Build:<br>
  [![build_NET_pipeline](https://github.com/skylinegtr124/github-actions-p1/actions/workflows/build_NET_pipeline.yml/badge.svg)](https://github.com/skylinegtr124/github-actions-p1/actions/workflows/build_NET_pipeline.yml)
test
