const ENV = {
  dev: {
    apiUrl: 'http://localhost:44367',
    oAuthConfig: {
      issuer: 'http://localhost:44367',
      clientId: 'howtodev_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access howtodev',
    },
    localization: {
      defaultResourceName: 'howtodev',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44367',
    oAuthConfig: {
      issuer: 'http://localhost:44367',
      clientId: 'howtodev_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access howtodev',
    },
    localization: {
      defaultResourceName: 'howtodev',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
