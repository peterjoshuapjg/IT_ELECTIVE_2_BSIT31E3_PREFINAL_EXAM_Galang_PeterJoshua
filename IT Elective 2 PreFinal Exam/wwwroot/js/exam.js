

(function () {
    "use strict";

    // ---- Load question data (rendered by the Controller/View) ----
    const dataEl = document.getElementById("questions-data");
    const questions = JSON.parse((dataEl && dataEl.textContent) || "[]");
    const totalQuestions = questions.length;

    let currentIndex = 0; // zero-based index into `questions`

    // ---- Cache DOM references ----
    const els = {
        counter: document.getElementById("exam-counter"),
        progressFill: document.getElementById("progress-fill"),
        navigatorGrid: document.getElementById("navigator-grid"),
        questionNumber: document.getElementById("question-number"),
        questionText: document.getElementById("question-text"),
        choicesContainer: document.getElementById("choices-container"),
        questionCard: document.getElementById("question-card"),
        btnPrev: document.getElementById("btn-prev"),
        btnNext: document.getElementById("btn-next"),
    };

    // ---- Build the question navigator (1, 2, 3 ... 20) once ----
    function buildNavigator() {
        els.navigatorGrid.innerHTML = "";
        questions.forEach((q, idx) => {
            const btn = document.createElement("button");
            btn.type = "button";
            btn.className = "nav-btn";
            btn.textContent = String(q.number);
            btn.setAttribute("aria-label", "Go to question " + q.number);
            btn.addEventListener("click", () => goToQuestion(idx));
            els.navigatorGrid.appendChild(btn);
        });
    }

    // ---- Render whichever question is "current" ----
    function renderQuestion() {
        const q = questions[currentIndex];
        if (!q) return; // defensive: never let a missing question render as "undefined"

        // Small transition: fade/scale the card out and back in.
        els.questionCard.style.animation = "none";
        // Force reflow so the animation can restart.
        void els.questionCard.offsetWidth;
        els.questionCard.style.animation = "";

        els.questionNumber.textContent = "Q" + q.number;
        els.questionText.textContent = q.text || "";

        els.choicesContainer.innerHTML = "";
        (q.choices || []).forEach((choice) => {
            const btn = document.createElement("button");
            btn.type = "button";
            btn.className = "choice-btn choice-btn--readonly";
            if (q.selectedAnswer === choice.letter) {
                btn.classList.add("selected");
            }
            const letterSpan = document.createElement("span");
            letterSpan.className = "choice-btn__letter";
            letterSpan.textContent = choice.letter || "";
            const textSpan = document.createElement("span");
            textSpan.textContent = choice.text || "";
            btn.appendChild(letterSpan);
            btn.appendChild(textSpan);
            // Read-only: displayed only, never clickable.
            btn.disabled = true;
            btn.setAttribute("aria-disabled", "true");
            els.choicesContainer.appendChild(btn);
        });

        els.counter.textContent = "Question " + (currentIndex + 1) + " of " + totalQuestions;
        els.progressFill.style.width = (((currentIndex + 1) / totalQuestions) * 100) + "%";

        els.btnPrev.disabled = currentIndex === 0;
        els.btnNext.disabled = currentIndex === totalQuestions - 1;

        updateNavigatorHighlights();
    }

    function updateNavigatorHighlights() {
        const buttons = els.navigatorGrid.querySelectorAll(".nav-btn");
        buttons.forEach((btn, idx) => {
            const q = questions[idx];
            btn.classList.remove("current", "answered");
            if (idx === currentIndex) {
                btn.classList.add("current");
            } else if (q.selectedAnswer) {
                btn.classList.add("answered");
            }
        });
    }

    function goToQuestion(index) {
        if (index < 0 || index >= totalQuestions) return;
        currentIndex = index;
        renderQuestion();
        els.questionCard.scrollIntoView({ behavior: "smooth", block: "start" });
    }

    // ---- Navigation buttons ----
    els.btnPrev.addEventListener("click", () => goToQuestion(currentIndex - 1));
    els.btnNext.addEventListener("click", () => goToQuestion(currentIndex + 1));

    // ---- Init ----
    buildNavigator();
    renderQuestion();
})();
