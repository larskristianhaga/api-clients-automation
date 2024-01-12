ARG RUBY_VERSION
FROM ruby:${RUBY_VERSION}-bullseye

SHELL ["/bin/bash", "--login", "-c"]

ARG JAVA_VERSION
ARG NODE_VERSION

WORKDIR /app

# Java
RUN apt-get update \
    && apt-get install -y --no-install-recommends  curl zip unzip \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/*
RUN curl -s "https://get.sdkman.io" | bash
RUN source "/root/.sdkman/bin/sdkman-init.sh" \
    && sdk install java ${JAVA_VERSION}-tem

# Node
RUN curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.39.7/install.sh | bash \
    && source /root/.nvm/nvm.sh \
    && nvm install ${NODE_VERSION} \
    && nvm alias default ${NODE_VERSION} \
    && nvm use default \
    && npm install -g yarn

# Autolink repository https://docs.github.com/en/packages/learn-github-packages/connecting-a-repository-to-a-package
LABEL org.opencontainers.image.source=https://github.com/algolia/api-clients-automation
LABEL org.opencontainers.image.revision=latest

ENTRYPOINT ["/bin/bash", "-l", "-c"]
