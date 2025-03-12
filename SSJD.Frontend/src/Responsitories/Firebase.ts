import { initializeApp } from "firebase/app";
import { getAuth, GoogleAuthProvider } from "firebase/auth";

const firebaseConfig = {
  apiKey: "AIzaSyBtGf1305NHWDxtfZSnK3t7TVqfDrdW9bI",
  authDomain: "ssjd-store.firebaseapp.com",
  projectId: "ssjd-store",
  storageBucket: "ssjd-store.firebasestorage.app",
  messagingSenderId: "481439794251",
  appId: "1:481439794251:web:32846a44d1e7b74e6f79ce",
};

const app = initializeApp(firebaseConfig);
const auth = getAuth(app);
const googleProvider = new GoogleAuthProvider();

export { auth, googleProvider }; // Đảm bảo đúng cú pháp export
